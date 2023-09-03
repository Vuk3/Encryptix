using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoClient.Helper;
using CryptoServer.Helper;
using CryptoClient.ServiceReference;
using CryptoClient.Forms;

namespace CryptoClient
{
    public partial class MainForm : Form
    {
        private FileExtend[] listRawFiles;
        private readonly IService service;
        public string rootFolder;
        public MainForm()
        {
            InitializeComponent();
            service = new ServiceClient();

            lblTotalFiles.Visible = false;
            btnAes.Visible = false;
            btnRC6.Visible = false;
            btnXXTEA.Visible = false;
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            listRawFiles = FilesAndFolders.FromListToArray(FilesAndFolders.ReadAllFiles(rootFolder = FilesAndFolders.OpenFolder(null)));
            if(listRawFiles != null)
            {
                lblTotalFiles.Text += listRawFiles.Length + " files";

                lblTotalFiles.Visible = true;
                btnAes.Visible = true;
                btnRC6.Visible = true;
                btnXXTEA.Visible = true;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAes_Click(object sender, EventArgs e)
        {
            //service.AesEncrypt(listRawFiles);

            AESForm a = new AESForm(listRawFiles, rootFolder);
            a.ShowDialog();

        }
    }
}
