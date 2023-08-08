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
        //public void Encrypt(List<FileExtend> list)
        //{
        //    using (Aes myAes = Aes.Create())
        //    {

        //        // Create an encryptor to perform the stream transform.
        //        ICryptoTransform encryptor = myAes.CreateEncryptor(myAes.Key, myAes.IV);

        //        using (MemoryStream msEncrypt = new MemoryStream())
        //        {
        //            using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
        //            {
        //                foreach (FileExtend file in list)
        //                {
        //                    string outputPath = Path.Combine(file.FilePath, "enc_" + file.FileName);

        //                    csEncrypt.Write(file.FileBytes, 0, file.FileBytes.Length);

        //                }
        //            }

        //            // Now msEncryptedData contains the encrypted data
        //            byte[] encryptedData = msEncrypt.ToArray();

        //            // You can save the encrypted data to a file or do further processing
        //            // For example:
        //            File.WriteAllBytes("encryptedOutput.dat", encryptedData);
        //        }
        //    }
        //}

        public void Encrypt(List<FileExtend> list)
        {
            using (Aes myAes = Aes.Create())
            {
                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = myAes.CreateEncryptor(myAes.Key, myAes.IV);

                foreach (FileExtend file in list)
                {
                    // Construct the output file path in the same directory as the input file
                    string outputPath = Path.Combine(file.FilePath, "enc_" + file.FileName);

                    using (FileStream fsEncryptedOutput = new FileStream(outputPath, FileMode.Create))
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(fsEncryptedOutput, encryptor, CryptoStreamMode.Write))
                        {
                            // Write the encrypted file bytes to the CryptoStream
                            csEncrypt.Write(file.FileBytes, 0, file.FileBytes.Length);
                        }
                    }
                }
            }
        }

    }
}
