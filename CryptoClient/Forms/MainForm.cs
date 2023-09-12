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

        private string lblTotalFilesDefault;
        public string rootFolder;


        public MainForm()
        {
            InitializeComponent();
            service = new ServiceClient();

            lblTotalFilesDefault = lblTotalFiles.Text;
            lblTotalFiles.Visible = false;
            btnAes.Visible = false;
            btnRC6.Visible = false;
            btnXXTEA.Visible = false;

            myLoader.Visible = false;
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            rootFolder = FilesAndFolders.OpenFolder(null);
            if (rootFolder != null)
            {
                myLoader.Visible = true;
                listRawFiles = FilesAndFolders.FromListToArray(FilesAndFolders.ReadAllFiles(rootFolder));
                if (listRawFiles != null)
                {
                    lblTotalFiles.Text += listRawFiles.Length + " files";

                    lblTotalFiles.Visible = true;
                    btnAes.Visible = true;
                    btnRC6.Visible = true;
                    btnXXTEA.Visible = true;
                }
                myLoader.Visible = false;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAes_Click(object sender, EventArgs e)
        {
            AESForm a = new AESForm(listRawFiles, rootFolder);
            a.ShowDialog();
            lblTotalFiles.Text = lblTotalFilesDefault;
            lblTotalFiles.Visible = false;

        }

        private void btnRC6_Click(object sender, EventArgs e)
        {
            RC6Form r = new RC6Form(listRawFiles, rootFolder);
            r.ShowDialog();
            lblTotalFiles.Text = lblTotalFilesDefault;
            lblTotalFiles.Visible = false;
        }

        private void btnXXTEA_Click(object sender, EventArgs e)
        {
            XXTEAForm x = new XXTEAForm(listRawFiles, rootFolder);
            x.ShowDialog();
            lblTotalFiles.Text = lblTotalFilesDefault;
            lblTotalFiles.Visible = false;
        }
    }
}
