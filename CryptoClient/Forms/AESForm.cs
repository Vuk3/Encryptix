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
using System.Timers;

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

        private int listSize;

        Stopwatch stopwatch;

        private System.Timers.Timer timer;

        private CancellationTokenSource cancellationTokenSource;

        private bool enc;

        private static int mbps;

        private string message;
        public AESForm()
        {
            InitializeComponent();
            service = new ServiceClient();

        }

        public AESForm(FileExtend[] listRawFiles, string rootFolder, int size)
        {
            InitializeComponent();
            Initialize(listRawFiles, rootFolder, size);

            service = new ServiceClient();

        }

        private void Initialize(FileExtend[] listRawFiles, string rootFolder, int size)
        {
            this.inputAesIV.MaxLength = 16;
            this.inputAesKey.MaxLength = 32;

            this.listRawFiles = listRawFiles;
            this.rootFolder = rootFolder;

            this.lblEncAESDone.Visible = false;
            this.lblDecAESDone.Visible = false;

            myLoader.Visible = false;

            if (listRawFiles.Length < 10)
            {
                mbps = 20 * 1024 * 1024;
            }
            else if(listRawFiles.Length > 100) { 
                mbps = 10 * 1024 * 1024;
            }
            else
            {
                mbps = 15 * 1024 * 1024;
            }

            

            this.listSize = size;

            stopwatch = new Stopwatch();

            progressDone.Visible = false;
            progressDone.Maximum = listSize;
            progressDone.Minimum = 0;
            progressDone.Step = (int)listSize / mbps;
            progressDone.Style = ProgressBarStyle.Continuous;


            timer = new System.Timers.Timer(1000);
            timer.Elapsed += TimerElapsed;
        }

        private async void PerformProgressBar()
        {
            cancellationTokenSource = new CancellationTokenSource();

            await Task.Run(async () =>
            {
                for (int i = 0; i <= 0.9 * listSize; i += mbps)
                {
                    if (cancellationTokenSource.Token.IsCancellationRequested)
                    {
                        break;
                    }
                    //SetProgress(i);
                    Invoke(new Action(() =>
                    {
                        this.progressDone.Value = i;
                    }));
                    await Task.Delay(1000);
                }
            }, cancellationTokenSource.Token);
        }
        private void DisableControls()
        {
            inputAesIV.Enabled = false;
            inputAesKey.Enabled = false;
            btnAesDec.Enabled = false;
            btnAesEnc.Enabled = false;
            cbxAESPar.Enabled = false;
        }
        private void EnableControls()
        {

            inputAesIV.Enabled = true;
            inputAesKey.Enabled = true;
            btnAesDec.Enabled = true;
            btnAesEnc.Enabled = true;
            cbxAESPar.Enabled = true;
        }
        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                EnableControls();
                myLoader.Visible = false;
                progressDone.Value = 0;
                progressDone.Visible = false;
                timer.Stop();
                if (enc)
                {
                    this.lblEncAESDone.Visible = true;
                    this.lblEncAESDone.Text += (stopwatch.ElapsedMilliseconds / 1000.0).ToString("0.00") + " seconds";
                }
                else
                {
                    this.lblDecAESDone.Visible = true;
                    this.lblDecAESDone.Text += (stopwatch.ElapsedMilliseconds / 1000.0).ToString("0.00") + " seconds";

                }
            }));

        }

        private bool ValidateInputs()
        {
            message = "";
            if (inputAesKey.Text.Length != 32)
                message += "The key must consist of 32 characters.\n";
            if (inputAesIV.Text.Length != 16)
                message += "The IV must consist of 16 characters.\n";
            if (message == "")
                return true;
            else
                return false;
        }
        private void btnAesEnc_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                aesIVtxt = this.inputAesIV.Text;
                aesKeytxt = this.inputAesKey.Text;

                aesIVbytes = Types.StringToBytes(aesIVtxt);
                aesKeybytes = Types.StringToBytes(aesKeytxt);

                stopwatch.Reset();
                stopwatch.Start();

                myLoader.Visible = true;

                DisableControls();

                //-----------------------------------------

                Task.Run(() =>
                {
                    PerformProgressBar();
                    Invoke(new Action(() =>
                    {
                        progressDone.Visible = true;
                    }));
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
                    cancellationTokenSource?.Cancel();
                    this.progressDone.Value = this.progressDone.Maximum;
                    stopwatch.Stop();
                    this.enc = true;
                    timer.Start();


                    listRawFiles = FilesAndFolders.FromListToArray(FilesAndFolders.ReadAllFiles(rootFolder = FilesAndFolders.OpenFolder(rootFolder) + "_encAES"));
                    message = "";

                }, TaskScheduler.FromCurrentSynchronizationContext());
            }



        }

        private void btnAesDec_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                aesIVtxt = this.inputAesIV.Text;
                aesKeytxt = this.inputAesKey.Text;

                aesIVbytes = Types.StringToBytes(aesIVtxt);
                aesKeybytes = Types.StringToBytes(aesKeytxt);

                stopwatch.Reset();
                stopwatch.Start();

                myLoader.Visible = true;

                DisableControls();

                Task.Run(() =>
                {
                    PerformProgressBar();
                    Invoke(new Action(() =>
                    {
                        progressDone.Visible = true;
                    }));
                    if (cbxAESPar.Checked)
                    {
                        service.AesDecryptP(listRawFiles, aesKeybytes, aesIVbytes, rootFolder);
                    }
                    else
                    {
                        service.AesDecrypt(listRawFiles, aesKeybytes, aesIVbytes, rootFolder);
                    }
                }).ContinueWith((task) =>
                {
                    cancellationTokenSource?.Cancel();
                    this.progressDone.Value = this.progressDone.Maximum;
                    stopwatch.Stop();
                    this.enc = false;
                    timer.Start();

                    listRawFiles = FilesAndFolders.FromListToArray(FilesAndFolders.ReadAllFiles(FilesAndFolders.OpenFolder(rootFolder)));
                    message = "";

                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
            else
            {
                MessageBox.Show(message);
            }

           


        }

        private void imgExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //------------ Dragging form -----------------------
        private bool isDragging;
        private Point offset;
        private void AESForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offset = new Point(e.X, e.Y);
            }
        }

        private void AESForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void AESForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }
    }
}
