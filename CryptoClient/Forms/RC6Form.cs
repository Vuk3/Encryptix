using CryptoClient.Helper;
using CryptoClient.ServiceReference;
using CryptoServer.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoClient.Forms
{
    public partial class RC6Form : Form
    {
        private readonly IService service;
        private FileExtend[] listRawFiles;

        private string RC6Keytxt;

        private byte[] RC6Keybytes;

        private string rootFolder;
        public RC6Form()
        {
            InitializeComponent();
            service = new ServiceClient();
        }

        public RC6Form(FileExtend[] listRawFiles, string rootFolder)
        {
            InitializeComponent();
            Initialize(listRawFiles, rootFolder);

            service = new ServiceClient();
        }

        private void Initialize(FileExtend[] listRawFiles, string rootFolder)
        {
            this.inputRC6Key.MaxLength = 16;

            this.listRawFiles = listRawFiles;
            this.rootFolder = rootFolder;
        }

        private void btnRC6Encrypt_Click(object sender, EventArgs e)
        {
            RC6Keytxt = this.inputRC6Key.Text;

            RC6Keybytes = Types.StringToBytes(RC6Keytxt);

            service.RC6Encrypt(listRawFiles, RC6Keybytes, rootFolder);

            listRawFiles = FilesAndFolders.FromListToArray(FilesAndFolders.ReadAllFiles(rootFolder = FilesAndFolders.OpenFolder(rootFolder) + "_encRC6"));
        }

        private void btnRC6Decrypt_Click(object sender, EventArgs e)
        {
            RC6Keytxt = this.inputRC6Key.Text;

            RC6Keybytes = Types.StringToBytes(RC6Keytxt);

            service.RC6Decrypt(listRawFiles, RC6Keybytes, rootFolder);

            listRawFiles = FilesAndFolders.FromListToArray(FilesAndFolders.ReadAllFiles(FilesAndFolders.OpenFolder(rootFolder)));
        }
    }
}
