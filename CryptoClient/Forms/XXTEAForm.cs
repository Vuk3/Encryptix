using CryptoClient.Helper;
using CryptoClient.ServiceReference;
using CryptoServer.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        Stopwatch stopwatch;

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

            this.lblEncXXTEADone.Visible = false;
            this.lblDecXXTEADone.Visible = false;

            stopwatch = new Stopwatch();

        }

        private void btnXXTEAEnc_Click(object sender, EventArgs e)
        {
            XXTEAKeytxt = this.inputXXTEAKey.Text;

            XXTEAKeybytes = Types.StringToBytes(XXTEAKeytxt);

            stopwatch.Reset();
            stopwatch.Start();

            if (cbxXXTEAPar.Checked)
            {
                service.XXTEAEncryptP(listRawFiles, XXTEAKeybytes, rootFolder);
            }
            else
            {
                service.XXTEAEncrypt(listRawFiles, XXTEAKeybytes, rootFolder);
            }

            stopwatch.Stop();


            this.lblEncXXTEADone.Visible = true;
            this.lblEncXXTEADone.Text += (stopwatch.ElapsedMilliseconds / 1000.0).ToString("0.00") + " seconds";

            listRawFiles = FilesAndFolders.FromListToArray(FilesAndFolders.ReadAllFiles(rootFolder = FilesAndFolders.OpenFolder(rootFolder) + "_encXXTEA"));
        }

        private void btnXXTEADec_Click(object sender, EventArgs e)
        {
            XXTEAKeytxt = this.inputXXTEAKey.Text;

            XXTEAKeybytes = Types.StringToBytes(XXTEAKeytxt);

            stopwatch.Reset();
            stopwatch.Start();

            if (cbxXXTEAPar.Checked)
            {
                service.XXTEADecryptP(listRawFiles, XXTEAKeybytes, rootFolder);
            }
            else
            {
                service.XXTEADecrypt(listRawFiles, XXTEAKeybytes, rootFolder);
            }

            stopwatch.Stop();


            this.lblDecXXTEADone.Visible = true;
            this.lblDecXXTEADone.Text += (stopwatch.ElapsedMilliseconds / 1000.0).ToString("0.00") + " seconds";

            listRawFiles = FilesAndFolders.FromListToArray(FilesAndFolders.ReadAllFiles(rootFolder = FilesAndFolders.OpenFolder(rootFolder)));
        }
    }
}
