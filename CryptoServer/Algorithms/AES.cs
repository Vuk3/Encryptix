using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using CryptoServer.Helper;
using System.IO;

namespace CryptoServer.Algorithms
{
    internal class AES
    {
        private readonly HashMD5 shaM;
        public AES()
        {
            shaM = new HashMD5();
        }
        public void Encrypt(List<FileExtend> list, byte[] key, byte[] IV)
        {
            using (Aes myAes = Aes.Create())
            {
                myAes.Key = key;
                myAes.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = myAes.CreateEncryptor(myAes.Key, myAes.IV);

                foreach (FileExtend file in list)
                {
                    // Construct the output file path in the same directory as the input file
                    string outputPath = Path.Combine(file.FilePath, file.FileName + "_enc" + file.FileExtension);

                    string nameHashBeforeEnc = "Hash before encrypt:";

                    File.AppendAllText(Path.Combine(file.FilePath, file.FileName + "_hash.txt"), nameHashBeforeEnc + Environment.NewLine);

                    string valueHashBeforeEnc = shaM.GetString(shaM.GetBytes(file.FileBytes));

                    File.AppendAllText(Path.Combine(file.FilePath, file.FileName + "_hash.txt"), valueHashBeforeEnc + Environment.NewLine + Environment.NewLine);

                    using (FileStream fsEncryptedOutput = new FileStream(outputPath, FileMode.Create))
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(fsEncryptedOutput, encryptor, CryptoStreamMode.Write))
                        {
                            // Write the encrypted file bytes to the CryptoStream
                            csEncrypt.Write(file.FileBytes, 0, file.FileBytes.Length);
                        }
                    }

                    byte[] encryptedBytes = File.ReadAllBytes(outputPath);

                    string nameHashAfterEnc = "Hash after encrypt:";

                    File.AppendAllText(Path.Combine(file.FilePath, file.FileName + "_hash.txt"), nameHashAfterEnc + Environment.NewLine);

                    string valueHashAfterEnc = shaM.GetString(shaM.GetBytes(encryptedBytes));

                    File.AppendAllText(Path.Combine(file.FilePath, file.FileName + "_hash.txt"), valueHashAfterEnc + Environment.NewLine + Environment.NewLine);

                }
            }
        }

        //public void Decrypt(List<FileExtend> list, byte[] key, byte[] IV)
        //{
        //    using (Aes myAes = Aes.Create())
        //    {
        //        myAes.Key = key;
        //        myAes.IV = IV;

        //        // Create a decryptor to perform the stream transform.
        //        ICryptoTransform decryptor = myAes.CreateDecryptor(myAes.Key, myAes.IV);

        //        foreach (FileExtend file in list)
        //        {
        //            // Construct the output file path for decrypted files
        //            string outputPath = Path.Combine(file.FilePath, "dec_" + file.FileName);

        //            using (FileStream fsEncryptedInput = new FileStream(file.FilePath, FileMode.Open))
        //            using (CryptoStream csDecrypt = new CryptoStream(fsEncryptedInput, decryptor, CryptoStreamMode.Read))
        //            using (FileStream fsDecryptedOutput = new FileStream(outputPath, FileMode.Create))
        //            {
        //                int bytesRead;
        //                byte[] buffer = new byte[1024]; // You can adjust the buffer size

        //                while ((bytesRead = csDecrypt.Read(buffer, 0, buffer.Length)) > 0)
        //                {
        //                    fsDecryptedOutput.Write(buffer, 0, bytesRead);
        //                }
        //            }
        //        }
        //    }


        //}

        public void Decrypt(List<FileExtend> list, byte[] key, byte[] IV)
        {
            using (Aes myAes = Aes.Create())
            {
                myAes.Key = key;
                myAes.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = myAes.CreateDecryptor(myAes.Key, myAes.IV);

                foreach (FileExtend file in list)
                {
                    // Construct the output file path for the decrypted file
                    if(file.FileName.EndsWith("_enc", StringComparison.OrdinalIgnoreCase)){
                        string inputPath = Path.Combine(file.FilePath, file.FileName + file.FileExtension);

                        string outputPath = Path.Combine(file.FilePath, file.FileName.Substring(0, file.FileName.Length-4) + "_dec" + file.FileExtension);

                        string nameHashBeforeDec = "Hash before decrypt:";

                        File.AppendAllText(Path.Combine(file.FilePath, file.FileName.Substring(0, file.FileName.Length - 4) + "_hash.txt"), nameHashBeforeDec + Environment.NewLine);

                        string valueHashBeforeDec = shaM.GetString(shaM.GetBytes(file.FileBytes));

                        File.AppendAllText(Path.Combine(file.FilePath, file.FileName.Substring(0, file.FileName.Length - 4) + "_hash.txt"), valueHashBeforeDec + Environment.NewLine + Environment.NewLine);

                        using (FileStream fsEncryptedInput = new FileStream(inputPath, FileMode.Open))
                        {
                            using (CryptoStream csDecrypt = new CryptoStream(fsEncryptedInput, decryptor, CryptoStreamMode.Read))
                            {
                                using (FileStream fsDecryptedOutput = new FileStream(outputPath, FileMode.Create))
                                {
                                    byte[] buffer = new byte[4096];
                                    int bytesRead;

                                    // Read from the CryptoStream and write decrypted data to the output file
                                    while ((bytesRead = csDecrypt.Read(buffer, 0, buffer.Length)) > 0)
                                    {
                                        fsDecryptedOutput.Write(buffer, 0, bytesRead);
                                    }
                                }
                            }
                        }

                        byte[] decryptedBytes = File.ReadAllBytes(outputPath);


                        string nameHashAfterDec = "Hash after decrypt:";

                        File.AppendAllText(Path.Combine(file.FilePath, file.FileName.Substring(0, file.FileName.Length - 4) + "_hash.txt"), nameHashAfterDec + Environment.NewLine);

                        string valueHashAfterDec = shaM.GetString(shaM.GetBytes(decryptedBytes));

                        File.AppendAllText(Path.Combine(file.FilePath, file.FileName.Substring(0, file.FileName.Length - 4) + "_hash.txt"), valueHashAfterDec + Environment.NewLine + Environment.NewLine + "--------------------------------" + Environment.NewLine + Environment.NewLine);

                    }

                }
            }
        }

    }
}
