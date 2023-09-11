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

            if (!Directory.Exists(file.FilePath.Replace(rootFolder, rootFolder + $"_hash{algorithm}")))
            {
                Directory.CreateDirectory(file.FilePath.Replace(rootFolder, rootFolder + $"_hash{algorithm}"));
            }

            string nameHashBeforeEnc = "Hash before encrypt:";

            File.AppendAllText(Path.Combine(file.FilePath.Replace(rootFolder, rootFolder + $"_hash{algorithm}"), file.FileName + $"_hash{algorithm}.txt"), nameHashBeforeEnc + Environment.NewLine);

            string valueHashBeforeEnc = shaM.GetString(shaM.GetBytes(file.FileBytes));

            File.AppendAllText(Path.Combine(file.FilePath.Replace(rootFolder, rootFolder + $"_hash{algorithm}"), file.FileName + $"_hash{algorithm}.txt"), valueHashBeforeEnc + Environment.NewLine + Environment.NewLine);


        }

        public static void AfterEnc(FileExtend file, string algorithm, HashMD5 shaM, byte[] encryptedBytes, string rootFolder) {

            if (!Directory.Exists(file.FilePath.Replace(rootFolder, rootFolder + $"_hash{algorithm}")))
            {
                Directory.CreateDirectory(file.FilePath.Replace(rootFolder, rootFolder + $"_hash{algorithm}"));
            }

            string nameHashAfterEnc = "Hash after encrypt:";

            File.AppendAllText(Path.Combine(file.FilePath.Replace(rootFolder, rootFolder + $"_hash{algorithm}"), file.FileName + $"_hash{algorithm}.txt"), nameHashAfterEnc + Environment.NewLine);

            string valueHashAfterEnc = shaM.GetString(shaM.GetBytes(encryptedBytes));

            File.AppendAllText(Path.Combine(file.FilePath.Replace(rootFolder, rootFolder + $"_hash{algorithm}"), file.FileName + $"_hash{algorithm}.txt"), valueHashAfterEnc + Environment.NewLine + Environment.NewLine);
        }
        public static void BeforeDec(FileExtend file, string algorithm, HashMD5 shaM, string rootFolder)
        {
            if (!Directory.Exists(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - (4 + algorithm.Length)) + $"_hash{algorithm}")))
            {
                Directory.CreateDirectory(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - (4 + algorithm.Length)) + $"_hash{algorithm}"));
            }

            string nameHashBeforeDec = "Hash before decrypt:";

            File.AppendAllText(Path.Combine(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - (4 + algorithm.Length)) + $"_hash{algorithm}"), file.FileName.Substring(0, file.FileName.Length - (4 + algorithm.Length)) + $"_hash{algorithm}.txt"), nameHashBeforeDec + Environment.NewLine);

            string valueHashBeforeDec = shaM.GetString(shaM.GetBytes(file.FileBytes));

            File.AppendAllText(Path.Combine(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - (4 + algorithm.Length)) + $"_hash{algorithm}"), file.FileName.Substring(0, file.FileName.Length - (4+algorithm.Length)) + $"_hash{algorithm}.txt"), valueHashBeforeDec + Environment.NewLine + Environment.NewLine);
        }
        public static void AfterDec(FileExtend file, string algorithm, HashMD5 shaM, byte[] decryptedBytes, string rootFolder)
        {
            if (!Directory.Exists(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - (4 + algorithm.Length)) + $"_hash{algorithm}")))
            {
                Directory.CreateDirectory(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - (4 + algorithm.Length)) + $"_hash{algorithm}"));
            }

            string nameHashAfterDec = "Hash after decrypt:";

            File.AppendAllText(Path.Combine(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - (4 + algorithm.Length)) + $"_hash{algorithm}"), file.FileName.Substring(0, file.FileName.Length - (4 + algorithm.Length)) + $"_hash{algorithm}.txt"), nameHashAfterDec + Environment.NewLine);

            string valueHashAfterDec = shaM.GetString(shaM.GetBytes(decryptedBytes));

            File.AppendAllText(Path.Combine(file.FilePath.Replace(rootFolder, rootFolder.Substring(0, rootFolder.Length - (4 + algorithm.Length)) + $"_hash{algorithm}"), file.FileName.Substring(0, file.FileName.Length - (4 + algorithm.Length)) + $"_hash{algorithm}.txt"), valueHashAfterDec + Environment.NewLine + Environment.NewLine + "--------------------------------" + Environment.NewLine + Environment.NewLine);
        }
    }
}
