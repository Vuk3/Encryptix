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
    public partial class XXTEAForm : Form
    {
        private readonly IService service;
        private FileExtend[] listRawFiles;

        private string XXTEAKeytxt;

        private byte[] XXTEAKeybytes;

        private string rootFolder;
        public XXTEAForm()
        {
            InitializeComponent(); 
            service = new ServiceClient();
        }

        public XXTEAForm(FileExtend[] listRawFiles, string rootFolder)
        {
            InitializeComponent();
            Initialize(listRawFiles, rootFolder);

            service = new ServiceClient();
        }

        private void Initialize(FileExtend[] listRawFiles, string rootFolder)
        {
            this.inputXXTEAKey.MaxLength = 16;

            this.listRawFiles = listRawFiles;
            this.rootFolder = rootFolder;
        }

        private void btnXXTEAEnc_Click(object sender, EventArgs e)
        {
            XXTEAKeytxt = this.inputXXTEAKey.Text;

            XXTEAKeybytes = Types.StringToBytes(XXTEAKeytxt);

            service.XXTEAEncrypt(listRawFiles, XXTEAKeybytes, rootFolder);

            listRawFiles = FilesAndFolders.FromListToArray(FilesAndFolders.ReadAllFiles(rootFolder = FilesAndFolders.OpenFolder(rootFolder) + "_encXXTEA"));
        }

        private void btnXXTEADec_Click(object sender, EventArgs e)
        {
            XXTEAKeytxt = this.inputXXTEAKey.Text;

            XXTEAKeybytes = Types.StringToBytes(XXTEAKeytxt);

            service.XXTEADecrypt(listRawFiles, XXTEAKeybytes, rootFolder);

            listRawFiles = FilesAndFolders.FromListToArray(FilesAndFolders.ReadAllFiles(rootFolder = FilesAndFolders.OpenFolder(rootFolder)));
        }
    }
}
