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


        private const uint Delta = 0x9e3779b9;

        public static byte[] Encrypt(byte[] data, byte[] key)
        {
            if (key.Length != 16)
            {
                throw new ArgumentException("The key must be 128 bits (16 bytes) long.");
            }

            uint[] v = ToUIntArray(data);
            uint[] k = ToUIntArray(key);

            int n = v.Length;

            if (n < 1)
            {
                return new byte[0];
            }

            uint sum = 0;
            uint v0 = v[0];
            uint v1 = v[1]; // Initialize v1

            int rounds = 6 + 52 / n;

            while (rounds-- > 0)
            {
                sum = unchecked(sum + Delta);
                uint e = (sum >> 2) & 3;
                for (int i = 0; i < n - 1; i++)
                {
                    v0 = v[i];
                    v1 = unchecked(v[i + 1] += (((v0 >> 5) ^ (v1 << 2)) + ((v1 >> 3) ^ (v0 << 4))) ^ ((sum ^ v0) + (k[(int)(i & 3)] ^ v1)));
                }
                v0 = v[n - 1];
                v1 = unchecked(v[0] += (((v0 >> 5) ^ (v1 << 2)) + ((v1 >> 3) ^ (v0 << 4))) ^ ((sum ^ v0) + (k[(int)(n & 3)] ^ v1)));
            }

            // Replace the original v[0] and v[1] with v0 and v1
            v[0] = v0;
            v[1] = v1;

            return ToByteArray(v);
        }

        public static byte[] Decrypt(byte[] data, byte[] key)
        {
            if (key.Length != 16)
            {
                throw new ArgumentException("The key must be 128 bits (16 bytes) long.");
            }

            uint[] v = ToUIntArray(data);
            uint[] k = ToUIntArray(key);

            int n = v.Length;

            if (n < 1)
            {
                return new byte[0];
            }

            uint sum = unchecked((uint)(Delta * (6 + 52 / n)));
            uint v0 = v[0];
            uint v1 = v[n - 1];

            while (sum != 0)
            {
                int e = (int)((sum >> 2) & 3);
                for (int i = n - 1; i > 0; i--)
                {
                    v0 = v[i - 1];
                    v1 = unchecked(v[i] -= (((v0 >> 5) ^ (v1 << 2)) + ((v1 >> 3) ^ (v0 << 4))) ^ ((sum ^ v0) + (k[(int)(i & 3)] ^ v1)));
                }
                v0 = v[n - 1];
                v1 = unchecked(v[0] -= (((v0 >> 5) ^ (v1 << 2)) + ((v1 >> 3) ^ (v0 << 4))) ^ ((sum ^ v0) + (k[(int)(n & 3)] ^ v1)));
                sum = unchecked(sum - Delta);
            }

            return ToByteArray(v);
        }

        private static uint[] ToUIntArray(byte[] data)
        {
            int len = data.Length;
            int n = (len + 3) / 4;
            uint[] result = new uint[n];
            int i = 0;
            int offset = 0;

            while (len >= 4)
            {
                result[i++] = BitConverter.ToUInt32(data, offset);
                offset += 4;
                len -= 4;
            }

            if (len > 0)
            {
                byte[] tmp = new byte[4];
                for (int j = 0; j < len; j++)
                {
                    tmp[j] = data[offset + j];
                }
                result[i] = BitConverter.ToUInt32(tmp, 0);
            }

            return result;
        }

        private static byte[] ToByteArray(uint[] data)
        {
            int len = data.Length * 4;
            byte[] result = new byte[len];
            int i = 0;
            int offset = 0;

            for (int j = 0; j < data.Length; j++)
            {
                BitConverter.GetBytes(data[j]).CopyTo(result, offset);
                offset += 4;
            }

            return result;
        }
    }
}
