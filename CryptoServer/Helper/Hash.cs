using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoServer.Helper
{
    public class Hash
    {

        private SHA512 shaM;
        public Hash()
        {
            shaM = new SHA512Managed();
        }
        public byte[] GetBytes(byte[] data)
        {
            return shaM.ComputeHash(data);
        }

        public string GetString(byte[] data)
        {
            return BitConverter.ToString(data).Replace("-", "").ToLower();
        }
    }
}
