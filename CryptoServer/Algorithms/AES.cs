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
                    // Construct the output file path for decrypted files
                    string outputPath = Path.Combine(file.FilePath, "dec_" + file.FileName);

                    using (FileStream fsEncryptedInput = new FileStream(file.FilePath, FileMode.Open))
                    using (CryptoStream csDecrypt = new CryptoStream(fsEncryptedInput, decryptor, CryptoStreamMode.Read))
                    using (FileStream fsDecryptedOutput = new FileStream(outputPath, FileMode.Create))
                    {
                        int bytesRead;
                        byte[] buffer = new byte[1024]; // You can adjust the buffer size

                        while ((bytesRead = csDecrypt.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fsDecryptedOutput.Write(buffer, 0, bytesRead);
                        }
                    }
                }
            }


        }

    }
}
