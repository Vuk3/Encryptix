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
    public partial class RC6Form : Form
    {
        private readonly IService service;
        private FileExtend[] listRawFiles;

        private string RC6Keytxt;

        private byte[] RC6Keybytes;

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
            inputRC6Key.Enabled = false;
            btnRC6Decrypt.Enabled = false;
            btnRC6Encrypt.Enabled = false;
            cbxRC6Par.Enabled = false;
        }
        private void EnableControls()
        {
            inputRC6Key.Enabled = true;
            btnRC6Decrypt.Enabled = true;
            btnRC6Encrypt.Enabled = true;
            cbxRC6Par.Enabled = true;
        }
        public RC6Form()
        {
            InitializeComponent();
            service = new ServiceClient();
        }

        public RC6Form(FileExtend[] listRawFiles, string rootFolder, int size)
        {
            InitializeComponent();
            Initialize(listRawFiles, rootFolder, size);

            service = new ServiceClient();
        }

        private void Initialize(FileExtend[] listRawFiles, string rootFolder, int size)
        {
            this.inputRC6Key.MaxLength = 16;

            this.listRawFiles = listRawFiles;
            this.rootFolder = rootFolder;

            this.lblEncRC6Done.Visible = false;
            this.lblDecRC6Done.Visible = false;

            this.listSize = size;

            myLoader.Visible = false;

            mbps = 7 * 1024 * 1024;

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
                    this.lblEncRC6Done.Visible = true;
                    this.lblEncRC6Done.Text += (stopwatch.ElapsedMilliseconds / 1000.0).ToString("0.00") + " seconds";
                }
                else
                {
                    this.lblDecRC6Done.Visible = true;
                    this.lblDecRC6Done.Text += (stopwatch.ElapsedMilliseconds / 1000.0).ToString("0.00") + " seconds";

                }
            }));

        }

        private void btnRC6Encrypt_Click(object sender, EventArgs e)
        {
            RC6Keytxt = this.inputRC6Key.Text;

            RC6Keybytes = Types.StringToBytes(RC6Keytxt);

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
                if (cbxRC6Par.Checked)
                {
                    service.RC6EncryptP(listRawFiles, RC6Keybytes, rootFolder);
                }
                else
                {
                    service.RC6Encrypt(listRawFiles, RC6Keybytes, rootFolder);
                }
            }).ContinueWith((task) =>
            {

                cancellationTokenSource?.Cancel();
                this.progressDone.Value = this.progressDone.Maximum;
                stopwatch.Stop();
                this.enc = true;
                timer.Start();

                listRawFiles = FilesAndFolders.FromListToArray(FilesAndFolders.ReadAllFiles(rootFolder = FilesAndFolders.OpenFolder(rootFolder) + "_encRC6"));

            }, TaskScheduler.FromCurrentSynchronizationContext());

           
        }

        private void btnRC6Decrypt_Click(object sender, EventArgs e)
        {
            RC6Keytxt = this.inputRC6Key.Text;

            RC6Keybytes = Types.StringToBytes(RC6Keytxt);

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
                if (cbxRC6Par.Checked)
                {
                    service.RC6DecryptP(listRawFiles, RC6Keybytes, rootFolder);
                }
                else
                {
                    service.RC6Decrypt(listRawFiles, RC6Keybytes, rootFolder);
                }
            }).ContinueWith((task) =>
            {

                cancellationTokenSource?.Cancel();
                this.progressDone.Value = this.progressDone.Maximum;
                stopwatch.Stop();
                this.enc = false;
                timer.Start();


                listRawFiles = FilesAndFolders.FromListToArray(FilesAndFolders.ReadAllFiles(FilesAndFolders.OpenFolder(rootFolder)));

            }, TaskScheduler.FromCurrentSynchronizationContext());



        }
    }
}
