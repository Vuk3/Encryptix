﻿using CryptoServer.Algorithms;
using CryptoServer.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
namespace CryptoServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service : IService
    {
        RC6 rc6 = new RC6();
        AES aes = new AES();
        XXTEA xxtea = new XXTEA();

        public string GetData(string value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public void AesDecrypt(List<FileExtend> list, byte[] key, byte[] IV, string rootFolder, string hashFolder)
        {
            aes.Decrypt(list, key, IV, rootFolder, hashFolder);
        }

        public void AesEncrypt(List<FileExtend> list, byte[] key, byte[] IV, string rootFolder, string hashFolder)
        {
            aes.Encrypt(list, key, IV, rootFolder, hashFolder);
        }

        public void RC6Encrypt(List<FileExtend> list, byte[] key, string rootFolder, string hashFolder)
        {
            rc6.Encrypt(list, key, rootFolder, hashFolder);
        }

        public void RC6Decrypt(List<FileExtend> list, byte[] key, string rootFolder, string hashFolder)
        {
            rc6.Decrypt(list, key, rootFolder, hashFolder);
        }

        public void XXTEADecrypt(List<FileExtend> list, byte[] key, string rootFolder, string hashFolder)
        {
            xxtea.Decrypt(list, key, rootFolder, hashFolder);
        }

        public void XXTEAEncrypt(List<FileExtend> list, byte[] key, string rootFolder, string hashFolder)
        {
            xxtea.Encrypt(list, key, rootFolder, hashFolder);
        }

        //---------------- parallel functions

        public void AesDecryptP(List<FileExtend> list, byte[] key, byte[] IV, string rootFolder, string hashFolder)
        {
            aes.Decrypt(list, key, IV, rootFolder, hashFolder);
        }

        public void AesEncryptP(List<FileExtend> list, byte[] key, byte[] IV, string rootFolder, string hashFolder)
        {
            aes.Encrypt(list, key, IV, rootFolder, hashFolder);
        }

        public void RC6EncryptP(List<FileExtend> list, byte[] key, string rootFolder, string hashFolder)
        {
            rc6.Encrypt(list, key, rootFolder, hashFolder);
        }

        public void RC6DecryptP(List<FileExtend> list, byte[] key, string rootFolder, string hashFolder)
        {
            rc6.Decrypt(list, key, rootFolder, hashFolder);
        }

        public void XXTEADecryptP(List<FileExtend> list, byte[] key, string rootFolder, string hashFolder)
        {
            xxtea.Decrypt(list, key, rootFolder, hashFolder);
        }

        public void XXTEAEncryptP(List<FileExtend> list, byte[] key, string rootFolder, string hashFolder)
        {
            xxtea.Encrypt(list, key, rootFolder, hashFolder);
        }
    }
}
