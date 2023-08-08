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
        public void Encrypt(List<FileExtend> list)
        {
            using (Aes myAes = Aes.Create())
            {

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = myAes.CreateEncryptor(myAes.Key, myAes.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        foreach (FileExtend file in list)
                        {
                            csEncrypt.Write(file.FileBytes, 0, file.FileBytes.Length);

                        }
                    }
                }
            }
        }
    }
}
