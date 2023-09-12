using CryptoClient.Helper;
using CryptoClient.ServiceReference;
using CryptoServer.Helper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoClient.Forms;
using System.Diagnostics;
using System.Threading;

namespace CryptoClient.Forms
{
    public partial class AESForm : Form
    {
        private readonly IService service;
        private FileExtend[] listRawFiles;
        private string aesIVtxt;
        private string aesKeytxt;

        private byte[] aesIVbytes;
        private byte[] aesKeybytes;

        private string rootFolder;

        Stopwatch stopwatch;

        private void DisableControls() {
            inputAesIV.Enabled = false;
            inputAesKey.Enabled = false;
            btnAesDec.Enabled = false;
            btnAesEnc.Enabled = false;
            cbxAESPar.Enabled = false;
        }
        private void EnableControls() {
            inputAesIV.Enabled = true;
            inputAesKey.Enabled = true;
            btnAesDec.Enabled = true;
            btnAesEnc.Enabled = true;
            cbxAESPar.Enabled = true;
        }
        public AESForm()
        {
            InitializeComponent();
            service = new ServiceClient();

        }

        public AESForm(FileExtend[] listRawFiles, string rootFolder)
        {
            InitializeComponent();
            Initialize(listRawFiles, rootFolder);

            service = new ServiceClient();

        }

        private void Initialize(FileExtend[] listRawFiles, string rootFolder)
        {
            this.inputAesIV.MaxLength = 16;
            this.inputAesKey.MaxLength = 32;

            this.listRawFiles = listRawFiles;
            this.rootFolder = rootFolder;

            this.lblEncAESDone.Visible = false;
            this.lblDecAESDone.Visible = false;

            myLoader.Visible = false;

            panelCover.SendToBack();

            stopwatch = new Stopwatch();
        }

        private void btnAesEnc_Click(object sender, EventArgs e)
        {



            aesIVtxt = this.inputAesIV.Text;
            aesKeytxt = this.inputAesKey.Text;

            aesIVbytes = Types.StringToBytes(aesIVtxt);
            aesKeybytes = Types.StringToBytes(aesKeytxt);

            stopwatch.Reset();
            stopwatch.Start();

            myLoader.Visible = true;

            DisableControls();

            //panelCover.BringToFront();
            //panelCover.BackColor = Color.FromArgb(0, 255, 255, 255);
            //myLoader.BringToFront();
            //if (cbxAESPar.Checked)
            //{
            //    service.AesEncryptP(listRawFiles, aesKeybytes, aesIVbytes, rootFolder);
            //}
            //else
            //{
            //    service.AesEncrypt(listRawFiles, aesKeybytes, aesIVbytes, rootFolder);
            //}


            //ManualResetEvent threadDone = new ManualResetEvent(false);
            //Thread jobThread = new Thread(() =>
            //{
            //    try
            //    {
            //        if (cbxAESPar.Checked)
            //        {
            //            service.AesEncryptP(listRawFiles, aesKeybytes, aesIVbytes, rootFolder);
            //        }
            //        else
            //        {
            //            service.AesEncrypt(listRawFiles, aesKeybytes, aesIVbytes, rootFolder);
            //        }

            //    }
            //    finally
            //    {
            //        threadDone.Set();
            //    }
            //});

            //// Start the job thread
            //jobThread.Start();
            //threadDone.WaitOne();


            //-----------------------------------------

            Task.Run(() =>
            {
                if (cbxAESPar.Checked)
                {
                    service.AesEncryptP(listRawFiles, aesKeybytes, aesIVbytes, rootFolder);
                }
                else
                {
                    service.AesEncrypt(listRawFiles, aesKeybytes, aesIVbytes, rootFolder);
                }
            }).ContinueWith((task) =>
            {
                // This code runs when the job is done
                //myLoader.Invoke(new Action(() => myLoader.Visible = false));
                myLoader.Visible = false;

                //panelCover.SendToBack();
                //myLoader.SendToBack();

                stopwatch.Stop();

                EnableControls();

                this.lblEncAESDone.Visible = true;
                this.lblEncAESDone.Text += (stopwatch.ElapsedMilliseconds / 1000.0).ToString("0.00") + " seconds";

                listRawFiles = FilesAndFolders.FromListToArray(FilesAndFolders.ReadAllFiles(rootFolder = FilesAndFolders.OpenFolder(rootFolder) + "_encAES"));

            }, TaskScheduler.FromCurrentSynchronizationContext());

            //---------------------------------------------------------------


        }

        private void btnAesDec_Click(object sender, EventArgs e)
        {
            aesIVtxt = this.inputAesIV.Text;
            aesKeytxt = this.inputAesKey.Text;

            aesIVbytes = Types.StringToBytes(aesIVtxt);
            aesKeybytes = Types.StringToBytes(aesKeytxt);

            stopwatch.Reset();
            stopwatch.Start();

            if (cbxAESPar.Checked)
            {
                service.AesDecryptP(listRawFiles, aesKeybytes, aesIVbytes, rootFolder);
            }
            else
            {
                service.AesDecrypt(listRawFiles, aesKeybytes, aesIVbytes, rootFolder);
            }
            stopwatch.Stop();

            this.lblDecAESDone.Visible = true;
            this.lblDecAESDone.Text += (stopwatch.ElapsedMilliseconds / 1000.0).ToString("0.00") + " seconds";

            listRawFiles = FilesAndFolders.FromListToArray(FilesAndFolders.ReadAllFiles(FilesAndFolders.OpenFolder(rootFolder)));

        }
    }
}
