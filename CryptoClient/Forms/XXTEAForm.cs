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
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
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

        private int listSize;

        Stopwatch stopwatch;

        private System.Timers.Timer timer;

        private CancellationTokenSource cancellationTokenSource;

        private bool enc;

        private static int mbps;

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
            inputXXTEAKey.Enabled = false;
            btnXXTEADec.Enabled = false;
            btnXXTEAEnc.Enabled = false;
            cbxXXTEAPar.Enabled = false;
        }
        private void EnableControls()
        {
            inputXXTEAKey.Enabled = true;
            btnXXTEADec.Enabled = true;
            btnXXTEAEnc.Enabled = true;
            cbxXXTEAPar.Enabled = true;
        }
        public XXTEAForm()
        {
            InitializeComponent(); 
            service = new ServiceClient();
        }

        public XXTEAForm(FileExtend[] listRawFiles, string rootFolder, int size)
        {
            InitializeComponent();
            Initialize(listRawFiles, rootFolder, size);

            service = new ServiceClient();
        }

        private void Initialize(FileExtend[] listRawFiles, string rootFolder, int size)
        {
            this.inputXXTEAKey.MaxLength = 16;

            this.listRawFiles = listRawFiles;
            this.rootFolder = rootFolder;

            this.lblEncXXTEADone.Visible = false;
            this.lblDecXXTEADone.Visible = false;

            mbps = 13 * 1024 * 1024;

            myLoader.Visible = false;

            listSize = size;

            stopwatch = new Stopwatch();

            progressDone.Visible = false;
            progressDone.Maximum = listSize;
            progressDone.Minimum = 0;
            progressDone.Step = (int)listSize / mbps;
            progressDone.Style = ProgressBarStyle.Continuous;


            timer = new System.Timers.Timer(1000);
            timer.Elapsed += TimerElapsed;

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
                    this.lblEncXXTEADone.Visible = true;
                    this.lblEncXXTEADone.Text += (stopwatch.ElapsedMilliseconds / 1000.0).ToString("0.00") + " seconds";
                }
                else
                {
                    this.lblDecXXTEADone.Visible = true;
                    this.lblDecXXTEADone.Text += (stopwatch.ElapsedMilliseconds / 1000.0).ToString("0.00") + " seconds";

                }
            }));

        }
        private void btnXXTEAEnc_Click(object sender, EventArgs e)
        {
            XXTEAKeytxt = this.inputXXTEAKey.Text;

            XXTEAKeybytes = Types.StringToBytes(XXTEAKeytxt);

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
                if (cbxXXTEAPar.Checked)
                {
                    service.XXTEAEncryptP(listRawFiles, XXTEAKeybytes, rootFolder);
                }
                else
                {
                    service.XXTEAEncrypt(listRawFiles, XXTEAKeybytes, rootFolder);
                }
            }).ContinueWith((task) =>
            {

                cancellationTokenSource?.Cancel();
                this.progressDone.Value = this.progressDone.Maximum;
                stopwatch.Stop();
                this.enc = true;
                timer.Start();

                listRawFiles = FilesAndFolders.FromListToArray(FilesAndFolders.ReadAllFiles(rootFolder = FilesAndFolders.OpenFolder(rootFolder) + "_encXXTEA"));

            }, TaskScheduler.FromCurrentSynchronizationContext());

        }

        private void btnXXTEADec_Click(object sender, EventArgs e)
        {
            XXTEAKeytxt = this.inputXXTEAKey.Text;

            XXTEAKeybytes = Types.StringToBytes(XXTEAKeytxt);

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
                if (cbxXXTEAPar.Checked)
                {
                    service.XXTEADecryptP(listRawFiles, XXTEAKeybytes, rootFolder);
                }
                else
                {
                    service.XXTEADecrypt(listRawFiles, XXTEAKeybytes, rootFolder);
                }
            }).ContinueWith((task) =>
            {
                this.progressDone.Value = this.progressDone.Maximum;
                stopwatch.Stop();
                this.enc = false;
                timer.Start();

                listRawFiles = FilesAndFolders.FromListToArray(FilesAndFolders.ReadAllFiles(rootFolder = FilesAndFolders.OpenFolder(rootFolder)));

            }, TaskScheduler.FromCurrentSynchronizationContext());



        }
    }
}
