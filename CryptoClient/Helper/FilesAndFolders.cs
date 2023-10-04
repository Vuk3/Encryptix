using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoServer.Helper;

namespace CryptoClient.Helper
{
    internal class FilesAndFolders
    {
        
        public static string OpenFolder(string rootFolder)
        {
            if(rootFolder == null)
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                {
                    fbd.Description = "Select a Folder";
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        return fbd.SelectedPath;
                    }
                }
                return null;
            }
            else
            {
                return rootFolder;
            }
        }

        public static T[] FromListToArray<T>(List<T> list)
        {
            if (list == null || list.Count == 0) return null;
            return list.ToArray();
        }

        public static List<FileExtend> ReadAllFiles(string folderPath)
        {
            if(folderPath != null)
                return ReadFilesRecursively(folderPath);
            else return null;
        }

        public static List<FileExtend> ReadFilesRecursively(string folderPath)
        {
            List<FileExtend> filesInfo = new List<FileExtend>();
            ProcessFilesInFolder(folderPath, filesInfo);
            return filesInfo;
        }

        public static void ProcessFilesInFolder(string folderPath, List<FileExtend> filesInfo)
        {
            string[] files = Directory.GetFiles(folderPath);
            foreach (string filePath in files)
            {
                byte[] fileBytes = File.ReadAllBytes(filePath);
                FileExtend fileInfo = new FileExtend
                {
                    FileName = Path.GetFileNameWithoutExtension(filePath),
                    FileExtension = Path.GetExtension(filePath),
                    FilePath = Path.GetDirectoryName(filePath),
                    FileBytes = fileBytes
                };
                filesInfo.Add(fileInfo);
            }

            string[] subfolders = Directory.GetDirectories(folderPath);
            foreach (string subfolder in subfolders)
            {
                ProcessFilesInFolder(subfolder, filesInfo);
            }
        }
    }


}
