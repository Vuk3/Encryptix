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
        public void Encrypt(List<FileExtend> list, byte[] key, byte[] IV, string rootFolder)
        {
            using (Aes myAes = Aes.Create())
            {
                myAes.Key = key;
                myAes.IV = IV;
                myAes.Mode = CipherMode.CBC;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = myAes.CreateEncryptor(myAes.Key, myAes.IV);

                foreach (FileExtend file in list)
                {
                    // Construct the output file path in the same directory as the input file
                    string outputPath = Path.Combine(file.FilePath.Replace(rootFolder, rootFolder + "_encAES"), file.FileName + "_encAES" + file.FileExtension);

                    if (!Directory.Exists(file.FilePath.Replace(rootFolder, rootFolder + "_encAES")))
                    {
                        Directory.CreateDirectory(file.FilePath.Replace(rootFolder, rootFolder + "_encAES"));
                    }

                    WorkWithFiles.BeforeEnc(file, "AES", shaM, rootFolder);

                    using (FileStream fsEncryptedOutput = new FileStream(outputPath, FileMode.Create))
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(fsEncryptedOutput, encryptor, CryptoStreamMode.Write))
                        {
                            // Write the encrypted file bytes to the CryptoStream
                            csEncrypt.Write(file.FileBytes, 0, file.FileBytes.Length);
                        }
                    }

                    byte[] encryptedBytes = File.ReadAllBytes(outputPath);
                    WorkWithFiles.AfterEnc(file, "AES", shaM, encryptedBytes, rootFolder);

                }
            }
        }

        public void Decrypt(List<FileExtend> list, byte[] key, byte[] IV, string rootFolder)
        {
            using (Aes myAes = Aes.Create())
            {
                myAes.Key = key;
                myAes.IV = IV;
                myAes.Mode = CipherMode.CBC;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = myAes.CreateDecryptor(myAes.Key, myAes.IV);

                foreach (FileExtend file in list)
                {
                    // Construct the output file path for the decrypted file
                    if(file.FileName.EndsWith("_encAES", StringComparison.OrdinalIgnoreCase)){

                        string inputPath = Path.Combine(file.FilePath, file.FileName + file.FileExtension);

                        string outputPath = Path.Combine(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - 7) + "_decAES"), file.FileName.Substring(0, file.FileName.Length-7) + "_decAES" + file.FileExtension);

                        if (!Directory.Exists(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - 7) + "_decAES")))
                        {
                            Directory.CreateDirectory(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - 7) + "_decAES"));
                        }

                        WorkWithFiles.BeforeDec(file, "AES", shaM, rootFolder);

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
                        WorkWithFiles.AfterDec(file, "AES", shaM, decryptedBytes, rootFolder);

                    }

                }
            }
        }


        //----------------- parallel functions

        public void EncryptP(List<FileExtend> list, byte[] key, byte[] IV, string rootFolder)
        {
            using (Aes myAes = Aes.Create())
            {
                myAes.Key = key;
                myAes.IV = IV;
                myAes.Mode = CipherMode.CBC;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = myAes.CreateEncryptor(myAes.Key, myAes.IV);

                Parallel.ForEach(list, file =>
                {  
                    
                    // Construct the output file path in the same directory as the input file
                    string outputPath = Path.Combine(file.FilePath.Replace(rootFolder, rootFolder + "_encAES"), file.FileName + "_encAES" + file.FileExtension);

                    if (!Directory.Exists(file.FilePath.Replace(rootFolder, rootFolder + "_encAES")))
                    {
                        Directory.CreateDirectory(file.FilePath.Replace(rootFolder, rootFolder + "_encAES"));
                    }

                    WorkWithFiles.BeforeEnc(file, "AES", shaM, rootFolder);

                    using (FileStream fsEncryptedOutput = new FileStream(outputPath, FileMode.Create))
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(fsEncryptedOutput, encryptor, CryptoStreamMode.Write))
                        {
                            // Write the encrypted file bytes to the CryptoStream
                            csEncrypt.Write(file.FileBytes, 0, file.FileBytes.Length);
                        }
                    }

                    byte[] encryptedBytes = File.ReadAllBytes(outputPath);
                    WorkWithFiles.AfterEnc(file, "AES", shaM, encryptedBytes, rootFolder);


                });
            }
        }

        public void DecryptP(List<FileExtend> list, byte[] key, byte[] IV, string rootFolder)
        {
            using (Aes myAes = Aes.Create())
            {
                myAes.Key = key;
                myAes.IV = IV;
                myAes.Mode = CipherMode.CBC;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = myAes.CreateDecryptor(myAes.Key, myAes.IV);

                Parallel.ForEach(list, file =>
                {
                    // Construct the output file path for the decrypted file
                    if (file.FileName.EndsWith("_encAES", StringComparison.OrdinalIgnoreCase))
                    {

                        string inputPath = Path.Combine(file.FilePath, file.FileName + file.FileExtension);

                        string outputPath = Path.Combine(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - 7) + "_decAES"), file.FileName.Substring(0, file.FileName.Length - 7) + "_decAES" + file.FileExtension);

                        if (!Directory.Exists(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - 7) + "_decAES")))
                        {
                            Directory.CreateDirectory(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - 7) + "_decAES"));
                        }

                        WorkWithFiles.BeforeDec(file, "AES", shaM, rootFolder);

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
                        WorkWithFiles.AfterDec(file, "AES", shaM, decryptedBytes, rootFolder);

                    }
                });
          
            }
        }

    }
}
