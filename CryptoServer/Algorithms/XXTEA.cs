using CryptoServer.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoServer.Algorithms
{
    internal class XXTEA
    {
        private readonly Hash shaM;

        private const uint Delta = 0x9e3779b9;

        private string initialRoot;

        public XXTEA()
        {
            shaM = new Hash();
        }
        private static uint MX(uint sum, uint y, uint z, int p, uint e, uint[] k)
        {
            return (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (k[p & 3 ^ e] ^ z);
        }

        private static uint[] ToUIntArray(byte[] data)
        {
            Int32 length = data.Length;
            Int32 n = (((length & 3) == 0) ? (length >> 2) : ((length >> 2) + 1));
            UInt32[] result;
            result = new UInt32[n];
            for (int i = 0; i < length; i++)
            {
                result[i >> 2] |= (UInt32)data[i] << ((i & 3) << 3);
            }
            return result;
        }

        private static byte[] ToByteArray(uint[] data)
        {
            Int32 n = data.Length << 2;
            Byte[] result = new Byte[n];
            for (Int32 i = 0; i < n; i++)
            {
                result[i] = (Byte)(data[i >> 2] >> ((i & 3) << 3));
            }
            return result;
        }

        public void Encrypt(List<FileExtend> list, byte[] key, string rootFolder, string hashFolder)
        {

            foreach (FileExtend file in list)
            {
                initialRoot = list[0].FilePath;
                byte[] encryptedBytes;

                if (file.FileBytes == null || file.FileBytes.Length == 0 || key == null || key.Length != 16)
                {
                    throw new ArgumentException("Invalid input data or key.");
                }

                //string outputPath = Path.Combine(file.FilePath.Replace(rootFolder, rootFolder+"_encXXTEA"), file.FileName + "_encXXTEA" + file.FileExtension);

                //if (!Directory.Exists(file.FilePath.Replace(rootFolder, rootFolder + "_encXXTEA")))
                //{
                //    Directory.CreateDirectory(file.FilePath.Replace(rootFolder, rootFolder + "_encXXTEA"));
                //}

                string difference = WorkWithFiles.FindStringDifference(initialRoot, file.FilePath);

                string outputPath = Path.Combine(rootFolder + difference, file.FileName + file.FileExtension);

                if (!Directory.Exists(rootFolder + difference))
                {
                    Directory.CreateDirectory(rootFolder + difference);
                }

                WorkWithFiles.BeforeEnc(file, "XXTEA", shaM, hashFolder + difference);


                int originalLength = file.FileBytes.Length;
                int paddedLength = originalLength;
                while (paddedLength % 4 != 0)
                    paddedLength++;
                byte[] newBytes = new byte[paddedLength];
                file.FileBytes.CopyTo(newBytes, 0);


                byte[] lengthBytes = BitConverter.GetBytes(originalLength);

                encryptedBytes = new byte[lengthBytes.Length + newBytes.Length];
                lengthBytes.CopyTo(encryptedBytes, 0);

                uint[] v = ToUIntArray(newBytes);
                uint[] k = ToUIntArray(key);

                int n = v.Length;
                uint sum = 0;
                uint z = v[n - 1];

                int rounds = 6 + 52 / n;
                for (int i = 0; i < rounds; i++)
                {
                    sum = unchecked(sum + Delta);
                    uint e = sum >> 2 & 3;

                    uint y;
                    for (int j = 0; j < n - 1; j++)
                    {
                        y = v[j + 1];
                        z = v[j] = unchecked(v[j] + MX(sum, y, z, j, e, k));
                    }
                    y = v[0];
                    z = v[n - 1] = unchecked(v[n - 1] + MX(sum, y, z, n - 1, e, k));
                }

                Array.Copy(ToByteArray(v), 0, encryptedBytes, 4, ToByteArray(v).Length);

                File.WriteAllBytes(outputPath, encryptedBytes);

                WorkWithFiles.AfterEnc(file, "XXTEA", shaM, encryptedBytes, hashFolder + difference);


            }

        }

        public void Decrypt(List<FileExtend> list, byte[] key, string rootFolder, string hashFolder)
        {
            byte[] finallyDecryptedBytes;

            foreach (FileExtend file in list)
            {
                initialRoot = list[0].FilePath;

                if (file.FileBytes == null || file.FileBytes.Length == 0 || key == null || key.Length != 16)
                {
                    throw new ArgumentException("Invalid input data or key.");
                }
                string inputPath = Path.Combine(file.FilePath, file.FileName + file.FileExtension);

                string difference = WorkWithFiles.FindStringDifference(initialRoot, file.FilePath);

                string outputPath = Path.Combine(rootFolder + difference, file.FileName + file.FileExtension);

                if (!Directory.Exists(rootFolder + difference))
                {
                    Directory.CreateDirectory(rootFolder + difference);
                }

                WorkWithFiles.BeforeDec(file, "XXTEA", shaM, hashFolder + difference);



                int decryptedLength = BitConverter.ToInt32(file.FileBytes, 0);  
                byte[] bytesForDecrypt = new byte[file.FileBytes.Length - 4];
                Array.Copy(file.FileBytes, 4, bytesForDecrypt, 0, file.FileBytes.Length - 4);


                uint[] v = ToUIntArray(bytesForDecrypt);
                uint[] k = ToUIntArray(key);

                int n = v.Length;
                uint y = v[0];
                uint z = v[n - 1];

                int rounds = 6 + 52 / n;
                uint sum = unchecked((uint)(rounds * Delta));
                for (int i = 0; i < rounds; i++)
                {
                    uint e = sum >> 2 & 3;
                    for (int j = n - 1; j > 0; j--)
                    {
                        z = v[j - 1];
                        y = v[j] = unchecked(v[j] - MX(sum, y, z, j, e, k));
                    }
                    z = v[n - 1];
                    y = v[0] = unchecked(v[0] - MX(sum, y, z, 0, e, k));
                    sum = unchecked(sum - Delta);
                }

                byte[] decryptedBytes = ToByteArray(v);
                finallyDecryptedBytes = new byte[decryptedLength];
                Array.Copy(decryptedBytes, 0, finallyDecryptedBytes, 0, decryptedLength);


                File.WriteAllBytes(outputPath, finallyDecryptedBytes);

                WorkWithFiles.AfterDec(file, "XXTEA", shaM, finallyDecryptedBytes, hashFolder + difference);
            }

        }

        //----------------- parallel functions

        public void EncryptP(List<FileExtend> list, byte[] key, string rootFolder, string hashFolder)
        {

            Parallel.ForEach(list, file =>
            {
                initialRoot = list[0].FilePath;

                byte[] encryptedBytes;

                if (file.FileBytes == null || file.FileBytes.Length == 0 || key == null || key.Length != 16)
                {
                    throw new ArgumentException("Invalid input data or key.");
                }

                //string outputPath = Path.Combine(file.FilePath.Replace(rootFolder, rootFolder + "_encXXTEA"), file.FileName + "_encXXTEA" + file.FileExtension);

                //if (!Directory.Exists(file.FilePath.Replace(rootFolder, rootFolder + "_encXXTEA")))
                //{
                //    Directory.CreateDirectory(file.FilePath.Replace(rootFolder, rootFolder + "_encXXTEA"));
                //}


                string difference = WorkWithFiles.FindStringDifference(initialRoot, file.FilePath);


                string outputPath = Path.Combine(rootFolder + difference, file.FileName + file.FileExtension);

                if (!Directory.Exists(rootFolder + difference))
                {
                    Directory.CreateDirectory(rootFolder + difference);
                }

                WorkWithFiles.BeforeEnc(file, "XXTEA", shaM, hashFolder + difference);


                int originalLength = file.FileBytes.Length;
                int paddedLength = originalLength;
                while (paddedLength % 4 != 0)
                    paddedLength++;
                byte[] newBytes = new byte[paddedLength];
                file.FileBytes.CopyTo(newBytes, 0);
                byte[] lengthBytes = BitConverter.GetBytes(originalLength);


                encryptedBytes = new byte[lengthBytes.Length + newBytes.Length];
                lengthBytes.CopyTo(encryptedBytes, 0);

                uint[] v = ToUIntArray(newBytes);
                uint[] k = ToUIntArray(key);

                int n = v.Length;
                uint sum = 0;
                uint z = v[n - 1];

                int rounds = 6 + 52 / n;
                for (int i = 0; i < rounds; i++)
                {
                    sum = unchecked(sum + Delta);
                    uint e = sum >> 2 & 3;

                    uint y;
                    for (int j = 0; j < n - 1; j++)
                    {
                        y = v[j + 1];
                        z = v[j] = unchecked(v[j] + MX(sum, y, z, j, e, k));
                    }
                    y = v[0];
                    z = v[n - 1] = unchecked(v[n - 1] + MX(sum, y, z, n - 1, e, k));
                }

                Array.Copy(ToByteArray(v), 0, encryptedBytes, 4, ToByteArray(v).Length);

                File.WriteAllBytes(outputPath, encryptedBytes);

                WorkWithFiles.AfterEnc(file, "XXTEA", shaM, encryptedBytes, hashFolder + difference);

            });

        }

        public void DecryptP(List<FileExtend> list, byte[] key, string rootFolder, string hashFolder)
        {
            byte[] finallyDecryptedBytes;

            Parallel.ForEach(list, file =>
            {
                //if (file.FileName.EndsWith("_encXXTEA", StringComparison.OrdinalIgnoreCase))
                //{
                initialRoot = list[0].FilePath;

                if (file.FileBytes == null || file.FileBytes.Length == 0 || key == null || key.Length != 16)
                {
                    throw new ArgumentException("Invalid input data or key.");
                }
                string inputPath = Path.Combine(file.FilePath, file.FileName + file.FileExtension);

                //string outputPath = Path.Combine(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - 9) + "_decXXTEA"), file.FileName.Substring(0, file.FileName.Length - 9) + "_decXXTEA" + file.FileExtension);

                //if (!Directory.Exists(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - 9) + "_decXXTEA")))
                //{
                //    Directory.CreateDirectory(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - 9) + "_decXXTEA"));
                //}

                string difference = WorkWithFiles.FindStringDifference(initialRoot, file.FilePath);

                string outputPath = Path.Combine(rootFolder + difference, file.FileName + file.FileExtension);

                if (!Directory.Exists(rootFolder + difference))
                {
                    Directory.CreateDirectory(rootFolder + difference);
                }

                WorkWithFiles.BeforeDec(file, "XXTEA", shaM, hashFolder + difference);



                int decryptedLength = BitConverter.ToInt32(file.FileBytes, 0);
                byte[] bytesForDecrypt = new byte[file.FileBytes.Length - 4];
                Array.Copy(file.FileBytes, 4, bytesForDecrypt, 0, file.FileBytes.Length - 4);


                uint[] v = ToUIntArray(bytesForDecrypt);
                uint[] k = ToUIntArray(key);

                int n = v.Length;
                uint y = v[0];
                uint z = v[n - 1];

                int rounds = 6 + 52 / n;
                uint sum = unchecked((uint)(rounds * Delta));
                for (int i = 0; i < rounds; i++)
                {
                    uint e = sum >> 2 & 3;
                    for (int j = n - 1; j > 0; j--)
                    {
                        z = v[j - 1];
                        y = v[j] = unchecked(v[j] - MX(sum, y, z, j, e, k));
                    }
                    z = v[n - 1];
                    y = v[0] = unchecked(v[0] - MX(sum, y, z, 0, e, k));
                    sum = unchecked(sum - Delta);
                }

                byte[] decryptedBytes = ToByteArray(v);
                finallyDecryptedBytes = new byte[decryptedLength];
                Array.Copy(decryptedBytes, 0, finallyDecryptedBytes, 0, decryptedLength);


                File.WriteAllBytes(outputPath, finallyDecryptedBytes);

                WorkWithFiles.AfterDec(file, "XXTEA", shaM, finallyDecryptedBytes, hashFolder + difference);

                //}
            });

        }
    }
}
