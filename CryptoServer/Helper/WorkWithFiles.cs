using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoServer.Helper
{
    internal class WorkWithFiles
    {
        public static void BeforeEnc(FileExtend file, string algorithm, HashMD5 shaM, string rootFolder)
        {

            //if (!Directory.Exists(file.FilePath.Replace(rootFolder, rootFolder + $"_hash{algorithm}")))
            //{
            //    Directory.CreateDirectory(file.FilePath.Replace(rootFolder, rootFolder + $"_hash{algorithm}"));
            //}

            //string nameHashBeforeEnc = "Hash before encrypt:";

            //File.AppendAllText(Path.Combine(file.FilePath.Replace(rootFolder, rootFolder + $"_hash{algorithm}"), file.FileName + $"_hash{algorithm}.txt"), nameHashBeforeEnc + Environment.NewLine);

            //string valueHashBeforeEnc = shaM.GetString(shaM.GetBytes(file.FileBytes));

            //File.AppendAllText(Path.Combine(file.FilePath.Replace(rootFolder, rootFolder + $"_hash{algorithm}"), file.FileName + $"_hash{algorithm}.txt"), valueHashBeforeEnc + Environment.NewLine + Environment.NewLine);

            if (!Directory.Exists(rootFolder))
            {
                Directory.CreateDirectory(rootFolder);
            }

            string nameHashBeforeEnc = "Hash before encrypt:";

            File.AppendAllText(Path.Combine(rootFolder, file.FileName + ".txt"), nameHashBeforeEnc + Environment.NewLine);

            string valueHashBeforeEnc = shaM.GetString(shaM.GetBytes(file.FileBytes));

            File.AppendAllText(Path.Combine(rootFolder, file.FileName + ".txt"), valueHashBeforeEnc + Environment.NewLine + Environment.NewLine);



        }

        public static void AfterEnc(FileExtend file, string algorithm, HashMD5 shaM, byte[] encryptedBytes, string rootFolder)
        {

            //if (!Directory.Exists(file.FilePath.Replace(rootFolder, rootFolder + $"_hash{algorithm}")))
            //{
            //    Directory.CreateDirectory(file.FilePath.Replace(rootFolder, rootFolder + $"_hash{algorithm}"));
            //}

            //string nameHashAfterEnc = "Hash after encrypt:";

            //File.AppendAllText(Path.Combine(file.FilePath.Replace(rootFolder, rootFolder + $"_hash{algorithm}"), file.FileName + $"_hash{algorithm}.txt"), nameHashAfterEnc + Environment.NewLine);

            //string valueHashAfterEnc = shaM.GetString(shaM.GetBytes(encryptedBytes));

            //File.AppendAllText(Path.Combine(file.FilePath.Replace(rootFolder, rootFolder + $"_hash{algorithm}"), file.FileName + $"_hash{algorithm}.txt"), valueHashAfterEnc + Environment.NewLine + Environment.NewLine);

            if (!Directory.Exists(rootFolder))
            {
                Directory.CreateDirectory(rootFolder);
            }

            string nameHashAfterEnc = "Hash after encrypt:";

            File.AppendAllText(Path.Combine(rootFolder, file.FileName + ".txt"), nameHashAfterEnc + Environment.NewLine);

            string valueHashAfterEnc = shaM.GetString(shaM.GetBytes(encryptedBytes));

            File.AppendAllText(Path.Combine(rootFolder, file.FileName + ".txt"), valueHashAfterEnc + Environment.NewLine + Environment.NewLine);
        }
        public static void BeforeDec(FileExtend file, string algorithm, HashMD5 shaM, string rootFolder)
        {
            //if (!Directory.Exists(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - (4 + algorithm.Length)) + $"_hash{algorithm}")))
            //{
            //    Directory.CreateDirectory(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - (4 + algorithm.Length)) + $"_hash{algorithm}"));
            //}

            //string nameHashBeforeDec = "Hash before decrypt:";

            //File.AppendAllText(Path.Combine(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - (4 + algorithm.Length)) + $"_hash{algorithm}"), file.FileName.Substring(0, file.FileName.Length - (4 + algorithm.Length)) + $"_hash{algorithm}.txt"), nameHashBeforeDec + Environment.NewLine);

            //string valueHashBeforeDec = shaM.GetString(shaM.GetBytes(file.FileBytes));

            //File.AppendAllText(Path.Combine(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - (4 + algorithm.Length)) + $"_hash{algorithm}"), file.FileName.Substring(0, file.FileName.Length - (4+algorithm.Length)) + $"_hash{algorithm}.txt"), valueHashBeforeDec + Environment.NewLine + Environment.NewLine);

            if (!Directory.Exists(rootFolder))
            {
                Directory.CreateDirectory(rootFolder);
            }

            string nameHashBeforeDec = "Hash before decrypt:";

            File.AppendAllText(Path.Combine(rootFolder, file.FileName + ".txt"), nameHashBeforeDec + Environment.NewLine);

            string valueHashBeforeDec = shaM.GetString(shaM.GetBytes(file.FileBytes));

            File.AppendAllText(Path.Combine(rootFolder, file.FileName + ".txt"), valueHashBeforeDec + Environment.NewLine + Environment.NewLine);
        }
        public static void AfterDec(FileExtend file, string algorithm, HashMD5 shaM, byte[] decryptedBytes, string rootFolder)
        {
            //if (!Directory.Exists(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - (4 + algorithm.Length)) + $"_hash{algorithm}")))
            //{
            //    Directory.CreateDirectory(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - (4 + algorithm.Length)) + $"_hash{algorithm}"));
            //}

            //string nameHashAfterDec = "Hash after decrypt:";

            //File.AppendAllText(Path.Combine(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - (4 + algorithm.Length)) + $"_hash{algorithm}"), file.FileName.Substring(0, file.FileName.Length - (4 + algorithm.Length)) + $"_hash{algorithm}.txt"), nameHashAfterDec + Environment.NewLine);

            //string valueHashAfterDec = shaM.GetString(shaM.GetBytes(decryptedBytes));

            //File.AppendAllText(Path.Combine(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - (4 + algorithm.Length)) + $"_hash{algorithm}"), file.FileName.Substring(0, file.FileName.Length - (4 + algorithm.Length)) + $"_hash{algorithm}.txt"), valueHashAfterDec + Environment.NewLine + Environment.NewLine + "--------------------------------" + Environment.NewLine + Environment.NewLine);

            if (!Directory.Exists(rootFolder))
            {
                Directory.CreateDirectory(rootFolder);
            }

            string nameHashAfterDec = "Hash after decrypt:";

            File.AppendAllText(Path.Combine(rootFolder, file.FileName + ".txt"), nameHashAfterDec + Environment.NewLine);

            string valueHashAfterDec = shaM.GetString(shaM.GetBytes(decryptedBytes));

            File.AppendAllText(Path.Combine(rootFolder, file.FileName + ".txt"), valueHashAfterDec + Environment.NewLine + Environment.NewLine + "--------------------------------" + Environment.NewLine + Environment.NewLine);
        }

        public static string FindStringDifference(string str1, string str2)
        {
            // Find the common prefix length
            int commonPrefixLength = 0;
            int minLength = Math.Min(str1.Length, str2.Length);

            while (commonPrefixLength < minLength && str1[commonPrefixLength] == str2[commonPrefixLength])
            {
                commonPrefixLength++;
            }

            // Return the remaining portion of the second string
            if (commonPrefixLength == str1.Length)
            {
                return str2.Substring(commonPrefixLength);
            }
            else
            {
                return "";
            }
        }
    }


}
