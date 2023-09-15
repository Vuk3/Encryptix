using CryptoServer.Helper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoServer.Algorithms
{
    internal class RC6
    {
        private readonly HashMD5 shaM;

        private const int R = 20;
        private static uint[] S = new uint[2 * R + 4];
        private const int W = 32;
        private static byte[] Key;
        private const uint P32 = 0xB7E15163;
        private const uint Q32 = 0x9E3779B9;

        public RC6()
        {
            shaM = new HashMD5();
        }

        private static byte[] GetBytes(uint[] uints, int Long)
        {
            byte[] arrayBytes = new byte[Long * 4];
            for (int i = 0; i < Long; i++)
            {
                byte[] temp = BitConverter.GetBytes(uints[i]);
                temp.CopyTo(arrayBytes, i * 4);
            }
            return arrayBytes;
        }

        private static uint RotateLeft(uint x, int n)
        {
            return (x << n) | (x >> (W - n));
        }

        private static uint RotateRight(uint x, int n)
        {
            return (x >> n) | (x << (W - n));
        }

        private void GenerateKey(byte[] key)
        {
            Key = key;
            int c = 0;
            int i, j;
            c = key.Length / 4;
            uint[] L = new uint[c];
            for (i = 0; i < c; i++)
            {
                L[i] = BitConverter.ToUInt32(Key, i * 4);
            }
            S[0] = P32;
            for (i = 1; i < 2 * R + 4; i++)
                S[i] = S[i - 1] + Q32;
            uint A, B;
            A = B = 0;
            i = j = 0;
            int V = 3 * Math.Max(c, 2 * R + 4);
            for (int s = 1; s <= V; s++)
            {
                A = S[i] = RotateLeft((S[i] + A + B), 3);
                B = L[j] = RotateLeft((L[j] + A + B), (int)(A + B));
                i = (i + 1) % (2 * R + 4);
                j = (j + 1) % c;
            }

        }

        public void Encrypt(List<FileExtend> list, byte[] key, string rootFolder)
        {

            GenerateKey(key);
            
            foreach (FileExtend file in list)
            {
                byte[] encryptedBytes;

                string outputPath = Path.Combine(file.FilePath.Replace(rootFolder, rootFolder + "_encRC6"), file.FileName + "_encRC6" + file.FileExtension);

                if (!Directory.Exists(file.FilePath.Replace(rootFolder, rootFolder + "_encRC6")))
                {
                    Directory.CreateDirectory(file.FilePath.Replace(rootFolder, rootFolder + "_encRC6"));
                }

                WorkWithFiles.BeforeEnc(file, "RC6", shaM, rootFolder);



                //---------------------------------------------------------------------------------


                uint A, B, C, D;
                int originalLength = file.FileBytes.Length;
                
                int paddedLength = originalLength;
                while (paddedLength % 16 != 0)
                    paddedLength++;
                byte[] newBytes = new byte[paddedLength];
                file.FileBytes.CopyTo(newBytes, 0);

                byte[] lengthBytes = BitConverter.GetBytes(originalLength);
                byte[] bytesToEncrypt = new byte[lengthBytes.Length + newBytes.Length];
                lengthBytes.CopyTo(bytesToEncrypt, 0);
                newBytes.CopyTo(bytesToEncrypt, lengthBytes.Length);


                encryptedBytes = new byte[bytesToEncrypt.Length];
                lengthBytes.CopyTo(encryptedBytes, 0);
                for (int i = 4; i < bytesToEncrypt.Length; i = i + 16)
                {
                    A = BitConverter.ToUInt32(bytesToEncrypt, i);
                    B = BitConverter.ToUInt32(bytesToEncrypt, i + 4);
                    C = BitConverter.ToUInt32(bytesToEncrypt, i + 8);
                    D = BitConverter.ToUInt32(bytesToEncrypt, i + 12);
                    B += S[0];
                    D += S[1];
                    for (int j = 1; j <= R; j++)
                    {
                        uint t = RotateLeft((B * (2 * B + 1)), (int)(Math.Log(W, 2)));
                        uint u = RotateLeft((D * (2 * D + 1)), (int)(Math.Log(W, 2)));
                        A = (RotateLeft((A ^ t), (int)u)) + S[j * 2];
                        C = (RotateLeft((C ^ u), (int)t)) + S[j * 2 + 1];
                        uint temp = A;
                        A = B;
                        B = C;
                        C = D;
                        D = temp;
                    }
                    A += S[2 * R + 2];
                    C += S[2 * R + 3];
                    uint[] tempWords = new uint[4] { A, B, C, D };
                    byte[] block = GetBytes(tempWords, 4);
                    block.CopyTo(encryptedBytes, i);

                }

                File.WriteAllBytes(outputPath, encryptedBytes);

                WorkWithFiles.AfterEnc(file, "RC6", shaM, encryptedBytes, rootFolder);

            }

        }

        public void Decrypt(List<FileExtend> list, byte[] key, string rootFolder)
        {
            GenerateKey(key);
            byte[] decryptedBytes;
            byte[] finallyDecryptedBytes;
            foreach (FileExtend file in list)
            {
                if (file.FileName.EndsWith("_encRC6", StringComparison.OrdinalIgnoreCase))
                {
                    string inputPath = Path.Combine(file.FilePath, file.FileName + file.FileExtension);

                    string outputPath = Path.Combine(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - 7) + "_decRC6"), file.FileName.Substring(0, file.FileName.Length - 7) + "_decRC6" + file.FileExtension);

                    if (!Directory.Exists(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - 7) + "_decRC6")))
                    {
                        Directory.CreateDirectory(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - 7) + "_decRC6"));
                    }

                    WorkWithFiles.BeforeDec(file, "RC6", shaM, rootFolder);


                    uint A, B, C, D;
                    int i;

                    int decryptedLength = BitConverter.ToInt32(file.FileBytes, 0);

                    decryptedBytes = new byte[file.FileBytes.Length];
                    Array.Copy(file.FileBytes, sizeof(int), decryptedBytes, 0, decryptedLength);

                    for (i = 4; i < file.FileBytes.Length; i = i + 16)
                    {
                        A = BitConverter.ToUInt32(file.FileBytes, i);
                        B = BitConverter.ToUInt32(file.FileBytes, i + 4);
                        C = BitConverter.ToUInt32(file.FileBytes, i + 8);
                        D = BitConverter.ToUInt32(file.FileBytes, i + 12);
                        C -= S[2 * R + 3];
                        A -= S[2 * R + 2];
                        for (int j = R; j >= 1; j--)
                        {
                            uint temp = D;
                            D = C;
                            C = B;
                            B = A;
                            A = temp;
                            uint u = RotateLeft((D * (2 * D + 1)), (int)Math.Log(W, 2));
                            uint t = RotateLeft((B * (2 * B + 1)), (int)Math.Log(W, 2));
                            C = RotateRight((C - S[2 * j + 1]), (int)t) ^ u;
                            A = RotateRight((A - S[2 * j]), (int)u) ^ t;
                        }
                        D -= S[1];
                        B -= S[0];
                        uint[] tempWords = new uint[4] { A, B, C, D };
                        byte[] block = GetBytes(tempWords, 4);
                        block.CopyTo(decryptedBytes, i);
                    }

                    finallyDecryptedBytes = new byte[decryptedLength];

                    Array.Copy(decryptedBytes, 4, finallyDecryptedBytes, 0, decryptedLength);


                    File.WriteAllBytes(outputPath, finallyDecryptedBytes);

                    WorkWithFiles.AfterDec(file, "RC6", shaM, finallyDecryptedBytes, rootFolder);

                }

            }
        }

        //----------------- parallel functions


        public void EncryptP(List<FileExtend> list, byte[] key, string rootFolder)
        {

            GenerateKey(key);

            Parallel.ForEach(list, file =>
            {
                byte[] encryptedBytes;

                string outputPath = Path.Combine(file.FilePath.Replace(rootFolder, rootFolder + "_encRC6"), file.FileName + "_encRC6" + file.FileExtension);

                if (!Directory.Exists(file.FilePath.Replace(rootFolder, rootFolder + "_encRC6")))
                {
                    Directory.CreateDirectory(file.FilePath.Replace(rootFolder, rootFolder + "_encRC6"));
                }

                WorkWithFiles.BeforeEnc(file, "RC6", shaM, rootFolder);

                //---------------------------------------------------------------------------------

                uint A, B, C, D;
                int originalLength = file.FileBytes.Length;

                int paddedLength = originalLength;
                while (paddedLength % 16 != 0)
                    paddedLength++;
                byte[] newBytes = new byte[paddedLength];
                file.FileBytes.CopyTo(newBytes, 0);

                byte[] lengthBytes = BitConverter.GetBytes(originalLength);
                byte[] bytesToEncrypt = new byte[lengthBytes.Length + newBytes.Length];
                lengthBytes.CopyTo(bytesToEncrypt, 0);
                newBytes.CopyTo(bytesToEncrypt, lengthBytes.Length);


                encryptedBytes = new byte[bytesToEncrypt.Length];
                lengthBytes.CopyTo(encryptedBytes, 0);

                for (int i = 4; i < bytesToEncrypt.Length; i = i + 16)
                {
                    A = BitConverter.ToUInt32(bytesToEncrypt, i);
                    B = BitConverter.ToUInt32(bytesToEncrypt, i + 4);
                    C = BitConverter.ToUInt32(bytesToEncrypt, i + 8);
                    D = BitConverter.ToUInt32(bytesToEncrypt, i + 12);
                    B += S[0];
                    D += S[1];
                    for (int j = 1; j <= R; j++)
                    {
                        uint t = RotateLeft((B * (2 * B + 1)), (int)(Math.Log(W, 2)));
                        uint u = RotateLeft((D * (2 * D + 1)), (int)(Math.Log(W, 2)));
                        A = (RotateLeft((A ^ t), (int)u)) + S[j * 2];
                        C = (RotateLeft((C ^ u), (int)t)) + S[j * 2 + 1];
                        uint temp = A;
                        A = B;
                        B = C;
                        C = D;
                        D = temp;
                    }
                    A += S[2 * R + 2];
                    C += S[2 * R + 3];
                    uint[] tempWords = new uint[4] { A, B, C, D };
                    byte[] block = GetBytes(tempWords, 4);
                    block.CopyTo(encryptedBytes, i);

                }

                File.WriteAllBytes(outputPath, encryptedBytes);

                WorkWithFiles.AfterEnc(file, "RC6", shaM, encryptedBytes, rootFolder);
            });

        }

        public void DecryptP(List<FileExtend> list, byte[] key, string rootFolder)
        {
            GenerateKey(key);
            byte[] decryptedBytes;
            byte[] finallyDecryptedBytes;

            Parallel.ForEach(list, file =>
            {
                if (file.FileName.EndsWith("_encRC6", StringComparison.OrdinalIgnoreCase))
                {
                    string inputPath = Path.Combine(file.FilePath, file.FileName + file.FileExtension);

                    string outputPath = Path.Combine(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - 7) + "_decRC6"), file.FileName.Substring(0, file.FileName.Length - 7) + "_decRC6" + file.FileExtension);

                    if (!Directory.Exists(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - 7) + "_decRC6")))
                    {
                        Directory.CreateDirectory(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - 7) + "_decRC6"));
                    }

                    WorkWithFiles.BeforeDec(file, "RC6", shaM, rootFolder);


                    uint A, B, C, D;
                    int i;

                    int decryptedLength = BitConverter.ToInt32(file.FileBytes, 0);

                    decryptedBytes = new byte[file.FileBytes.Length];
                    Array.Copy(file.FileBytes, sizeof(int), decryptedBytes, 0, decryptedLength);

                    for (i = 4; i < file.FileBytes.Length; i = i + 16)
                    {
                        A = BitConverter.ToUInt32(file.FileBytes, i);
                        B = BitConverter.ToUInt32(file.FileBytes, i + 4);
                        C = BitConverter.ToUInt32(file.FileBytes, i + 8);
                        D = BitConverter.ToUInt32(file.FileBytes, i + 12);
                        C -= S[2 * R + 3];
                        A -= S[2 * R + 2];
                        for (int j = R; j >= 1; j--)
                        {
                            uint temp = D;
                            D = C;
                            C = B;
                            B = A;
                            A = temp;
                            uint u = RotateLeft((D * (2 * D + 1)), (int)Math.Log(W, 2));
                            uint t = RotateLeft((B * (2 * B + 1)), (int)Math.Log(W, 2));
                            C = RotateRight((C - S[2 * j + 1]), (int)t) ^ u;
                            A = RotateRight((A - S[2 * j]), (int)u) ^ t;
                        }

                        D -= S[1];
                        B -= S[0];

                        uint[] tempWords = new uint[4] { A, B, C, D };
                        byte[] block = GetBytes(tempWords, 4);
                        block.CopyTo(decryptedBytes, i);
                    }

                    finallyDecryptedBytes = new byte[decryptedLength];

                    Array.Copy(decryptedBytes, 4, finallyDecryptedBytes, 0, decryptedLength);

                    File.WriteAllBytes(outputPath, finallyDecryptedBytes);

                    WorkWithFiles.AfterDec(file, "RC6", shaM, finallyDecryptedBytes, rootFolder);

                }
            });
        }
    }
}
