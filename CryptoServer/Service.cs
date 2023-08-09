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

        public void AesDecrypt(List<FileExtend> list, byte[] key, byte[] IV)
        {
            aes.Decrypt(list, key, IV);
        }

        public void AesEncrypt(List<FileExtend> list, byte[] key, byte[] IV)
        {
            aes.Encrypt(list, key, IV);
        }

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
    }
}
