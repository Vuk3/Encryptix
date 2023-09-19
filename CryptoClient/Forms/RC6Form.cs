using CryptoClient.Helper;
using CryptoClient.ServiceReference;
using CryptoServer.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        private string message;

        private bool isExpanded;
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

            if (listRawFiles.Length < 10 && size > 100000000)
            {
                mbps = 6 * 1024 * 1024;
            }
            else if (listRawFiles.Length > 100 && size > 100000000)
            {
                mbps = 3 * 1024 * 1024;
            }
            else if (listRawFiles.Length >= 10 && listRawFiles.Length <= 100 && size > 100000000)
            {
                mbps = 5 * 1024 * 1024;
            }

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

        private bool ValidateInputs()
        {
            message = "";
            if (inputRC6Key.Text.Length != 16)
                message += "The key must consist of 16 characters.\n";
            if (message == "")
                return true;
            else
                return false;
        }
        private void btnRC6Encrypt_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
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

                    message = "";

                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
            else
            {
                MessageBox.Show(message);
            }
    

           
        }

        private void btnRC6Decrypt_Click(object sender, EventArgs e)
        {

            if (ValidateInputs())
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
        private void RC6Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offset = new Point(e.X, e.Y);
            }

        }

        private void RC6Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void RC6Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }


        // TREE VIEW

        private void btnRC6AllFiles_Click(object sender, EventArgs e)
        {
            if (isExpanded)
            {
                this.btnRC6AllFiles.Text = "Show all files";
                this.Size = new Size(this.Width / 2, this.Height);
                treeView1.Nodes.Clear();
            }
            else
            {
                this.btnRC6AllFiles.Text = "Hide files";
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
    }
}
