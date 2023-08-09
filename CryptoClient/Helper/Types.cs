using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoClient.Helper
{
    internal class Types
    {
        public static byte[] StringToBytes(string txt)
        {
            return Encoding.UTF8.GetBytes(txt);
        }
    }
}
