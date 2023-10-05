﻿using CryptoClient.Helper;
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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;

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
        private string encFolder;
        private string decFolder;
        private string hashFolder;


        private int listSize;

        Stopwatch stopwatch;

        private System.Timers.Timer timer;

        private CancellationTokenSource cancellationTokenSource;

        private bool enc;

        private static int mbps;

        private string message;

        private bool isExpanded;
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

            mbps = 20 * 1024 * 1024;

            if (listRawFiles.Length < 10 && size > 100000000)
            {
                mbps = 18 * 1024 * 1024;
            }
            else if(listRawFiles.Length > 100 && size > 100000000) { 
                mbps = 10 * 1024 * 1024;
            }
            else if( listRawFiles.Length >= 10 && listRawFiles.Length<=100 && size > 100000000)
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

            isExpanded = false;

            this.Size = new Size(this.Width / 2, this.Height);


            encFolder = "";
            decFolder = "";
            hashFolder = "";

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

        private bool ValidateInputs(bool isEnc)
        {
            message = "";
            if (inputAesKey.Text.Length != 32)
                message += "The key must consist of 32 characters.\n";
            if (inputAesIV.Text.Length != 16)
                message += "The IV must consist of 16 characters.\n";
            if (isEnc)
            {
                if (inputAESFolderEncReal.Text == "")
                    message += "Folder for storing encrypted files must be selected.\n";
            }
            else
            {
                if (inputAESFolderDecReal.Text == "")
                    message += "Folder for storing decrypted files must be selected.\n";
            }
            if (inputAESFolderHashReal.Text == "")
                message += "Folder for storing hash files must be selected.\n";

            if (message == "")
                return true;
            else
                return false;
        }
        private void btnAesEnc_Click(object sender, EventArgs e)
        {

            if (ValidateInputs(true))
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
                        service.AesEncryptP(listRawFiles, aesKeybytes, aesIVbytes, encFolder, hashFolder);
                    }
                    else
                    {
                        service.AesEncrypt(listRawFiles, aesKeybytes, aesIVbytes, encFolder, hashFolder);
                    }
                }).ContinueWith((task) =>
                {
                    cancellationTokenSource?.Cancel();
                    this.progressDone.Value = this.progressDone.Maximum;
                    stopwatch.Stop();
                    this.enc = true;
                    timer.Start();
                    listRawFiles = FilesAndFolders.FromListToArray(FilesAndFolders.ReadAllFiles(rootFolder = FilesAndFolders.OpenFolder(encFolder)));
                    message = "";

                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
            else
            {
                MessageBox.Show(message);
            }



        }

        private void btnAesDec_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(false))
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
                        service.AesDecryptP(listRawFiles, aesKeybytes, aesIVbytes, decFolder, hashFolder);
                    }
                    else
                    {
                        service.AesDecrypt(listRawFiles, aesKeybytes, aesIVbytes, decFolder, hashFolder);
                    }
                }).ContinueWith((task) =>
                {
                    cancellationTokenSource?.Cancel();
                    this.progressDone.Value = this.progressDone.Maximum;
                    stopwatch.Stop();
                    this.enc = false;
                    timer.Start();

                    //listRawFiles = FilesAndFolders.FromListToArray(FilesAndFolders.ReadAllFiles(FilesAndFolders.OpenFolder(rootFolder)));
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

        // TREE VIEW

        private void btnAesAllFiles_Click(object sender, EventArgs e)
        {
            if (isExpanded)
            {
                this.btnAesAllFiles.Text = "Show all files";
                this.Size = new Size(this.Width / 2, this.Height);
                treeView1.Nodes.Clear();
            }
            else
            {
                this.btnAesAllFiles.Text = "Hide files";
                this.Size = new Size(this.Width * 2, this.Height);
                PopulateTreeView(rootFolder);
                ExpandAllNodes(treeView1.Nodes);
            }
            isExpanded = !isExpanded;


        }

        private void PopulateTreeView(string rootDirectory)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(rootDirectory);

            if (!directoryInfo.Exists)
                return;

            TreeNode rootNode = new TreeNode(directoryInfo.Name);
            rootNode.Tag = directoryInfo.FullName;
            PopulateTreeView(rootDirectory, rootNode);
            treeView1.Nodes.Add(rootNode);
        }

        private void PopulateTreeView(string dir, TreeNode parentNode)
        {
            string[] subDirectories = Directory.GetDirectories(dir);
            foreach (string directory in subDirectories)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(directory);
                TreeNode directoryNode = new TreeNode(directoryInfo.Name);
                directoryNode.Tag = directoryInfo.FullName;
                parentNode.Nodes.Add(directoryNode);
                PopulateTreeView(directory, directoryNode);
            }

            string[] files = Directory.GetFiles(dir);
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                TreeNode fileNode = new TreeNode(fileInfo.Name);
                fileNode.Tag = fileInfo.FullName;
                parentNode.Nodes.Add(fileNode);
            }
        }

        private void ExpandAllNodes(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.Expand();
                ExpandAllNodes(node.Nodes);
            }
        }

        private void imgEncFolder_Click(object sender, EventArgs e)
        {
            encFolder = FilesAndFolders.OpenFolder(null);
            this.inputAESFolderEncReal.Text = encFolder;
        }

        private void imgDecFolder_Click(object sender, EventArgs e)
        {
            decFolder = FilesAndFolders.OpenFolder(null);
            this.inputAESFolderDecReal.Text = decFolder;
        }
        private void imgHashFolder_Click(object sender, EventArgs e)
        {
            hashFolder = FilesAndFolders.OpenFolder(null);
            this.inputAESFolderHashReal.Text = hashFolder;
        }
        private void cbxEncDefault_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxEncDefault.Checked)
            {
                inputAESFolderEncReal.Text = encFolder = rootFolder + "_encAES";
            }
            else
            {
                inputAESFolderEncReal.Text = "";
            }
        }

        private void cbxDecDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDecDefault.Checked)
            {
                inputAESFolderDecReal.Text = decFolder = rootFolder + "_decAES";
            }
            else
            {
                inputAESFolderDecReal.Text = "";
            }
        }

        private void cbxHashDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHashDefault.Checked)
            {
                inputAESFolderHashReal.Text = hashFolder = rootFolder + "_hashAES";
            }
            else
            {
                inputAESFolderHashReal.Text = "";
            }
        }
    }
}
