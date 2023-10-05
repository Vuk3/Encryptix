namespace CryptoClient.Forms
{
    partial class XXTEAForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblXXTEAKey = new System.Windows.Forms.Label();
            this.inputXXTEAKey = new System.Windows.Forms.TextBox();
            this.btnXXTEAEnc = new System.Windows.Forms.Button();
            this.btnXXTEADec = new System.Windows.Forms.Button();
            this.lblEncXXTEADone = new System.Windows.Forms.Label();
            this.lblDecXXTEADone = new System.Windows.Forms.Label();
            this.cbxXXTEAPar = new System.Windows.Forms.CheckBox();
            this.lblXXTEATitle = new System.Windows.Forms.Label();
            this.progressDone = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imgExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.myLoader = new System.Windows.Forms.PictureBox();
            this.btnXXTEAAllFiles = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.inputAESFolderHashReal = new System.Windows.Forms.TextBox();
            this.inputAESFolderDecReal = new System.Windows.Forms.TextBox();
            this.imgHashFolder = new System.Windows.Forms.PictureBox();
            this.imgDecFolder = new System.Windows.Forms.PictureBox();
            this.inputAESFolderEncReal = new System.Windows.Forms.TextBox();
            this.inputAESFolderEnc = new System.Windows.Forms.TextBox();
            this.imgEncFolder = new System.Windows.Forms.PictureBox();
            this.cbxHashDefault = new System.Windows.Forms.CheckBox();
            this.cbxDecDefault = new System.Windows.Forms.CheckBox();
            this.cbxEncDefault = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputAESFolderHash = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputAESFolderDec = new System.Windows.Forms.TextBox();
            this.lblAESDecFolder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLoader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHashFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDecFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEncFolder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblXXTEAKey
            // 
            this.lblXXTEAKey.AutoSize = true;
            this.lblXXTEAKey.Location = new System.Drawing.Point(11, 96);
            this.lblXXTEAKey.Name = "lblXXTEAKey";
            this.lblXXTEAKey.Size = new System.Drawing.Size(99, 13);
            this.lblXXTEAKey.TabIndex = 0;
            this.lblXXTEAKey.Text = "Key (16 characters)";
            // 
            // inputXXTEAKey
            // 
            this.inputXXTEAKey.Location = new System.Drawing.Point(14, 112);
            this.inputXXTEAKey.Multiline = true;
            this.inputXXTEAKey.Name = "inputXXTEAKey";
            this.inputXXTEAKey.Size = new System.Drawing.Size(179, 36);
            this.inputXXTEAKey.TabIndex = 1;
            // 
            // btnXXTEAEnc
            // 
            this.btnXXTEAEnc.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnXXTEAEnc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXXTEAEnc.FlatAppearance.BorderSize = 0;
            this.btnXXTEAEnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXXTEAEnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnXXTEAEnc.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnXXTEAEnc.Location = new System.Drawing.Point(14, 402);
            this.btnXXTEAEnc.Name = "btnXXTEAEnc";
            this.btnXXTEAEnc.Size = new System.Drawing.Size(79, 32);
            this.btnXXTEAEnc.TabIndex = 2;
            this.btnXXTEAEnc.Text = "Encrypt";
            this.btnXXTEAEnc.UseVisualStyleBackColor = false;
            this.btnXXTEAEnc.Click += new System.EventHandler(this.btnXXTEAEnc_Click);
            // 
            // btnXXTEADec
            // 
            this.btnXXTEADec.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnXXTEADec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXXTEADec.FlatAppearance.BorderSize = 0;
            this.btnXXTEADec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXXTEADec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnXXTEADec.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnXXTEADec.Location = new System.Drawing.Point(201, 401);
            this.btnXXTEADec.Name = "btnXXTEADec";
            this.btnXXTEADec.Size = new System.Drawing.Size(79, 32);
            this.btnXXTEADec.TabIndex = 3;
            this.btnXXTEADec.Text = "Decrypt";
            this.btnXXTEADec.UseVisualStyleBackColor = false;
            this.btnXXTEADec.Click += new System.EventHandler(this.btnXXTEADec_Click);
            // 
            // lblEncXXTEADone
            // 
            this.lblEncXXTEADone.AutoSize = true;
            this.lblEncXXTEADone.Location = new System.Drawing.Point(9, 476);
            this.lblEncXXTEADone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEncXXTEADone.Name = "lblEncXXTEADone";
            this.lblEncXXTEADone.Size = new System.Drawing.Size(117, 13);
            this.lblEncXXTEADone.TabIndex = 10;
            this.lblEncXXTEADone.Text = "Encryption complete in ";
            // 
            // lblDecXXTEADone
            // 
            this.lblDecXXTEADone.AutoSize = true;
            this.lblDecXXTEADone.Location = new System.Drawing.Point(9, 495);
            this.lblDecXXTEADone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDecXXTEADone.Name = "lblDecXXTEADone";
            this.lblDecXXTEADone.Size = new System.Drawing.Size(118, 13);
            this.lblDecXXTEADone.TabIndex = 11;
            this.lblDecXXTEADone.Text = "Decryption complete in ";
            // 
            // cbxXXTEAPar
            // 
            this.cbxXXTEAPar.AutoSize = true;
            this.cbxXXTEAPar.Location = new System.Drawing.Point(90, 166);
            this.cbxXXTEAPar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxXXTEAPar.Name = "cbxXXTEAPar";
            this.cbxXXTEAPar.Size = new System.Drawing.Size(90, 17);
            this.cbxXXTEAPar.TabIndex = 12;
            this.cbxXXTEAPar.Text = "Parallelization";
            this.cbxXXTEAPar.UseVisualStyleBackColor = true;
            // 
            // lblXXTEATitle
            // 
            this.lblXXTEATitle.AutoSize = true;
            this.lblXXTEATitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXXTEATitle.Location = new System.Drawing.Point(99, 64);
            this.lblXXTEATitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblXXTEATitle.Name = "lblXXTEATitle";
            this.lblXXTEATitle.Size = new System.Drawing.Size(81, 24);
            this.lblXXTEATitle.TabIndex = 14;
            this.lblXXTEATitle.Text = "XXTEA";
            // 
            // progressDone
            // 
            this.progressDone.Location = new System.Drawing.Point(116, 448);
            this.progressDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressDone.Name = "progressDone";
            this.progressDone.Size = new System.Drawing.Size(75, 19);
            this.progressDone.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CryptoClient.Properties.Resources.justLogoTransparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // imgExit
            // 
            this.imgExit.BackgroundImage = global::CryptoClient.Properties.Resources.XredTransparent;
            this.imgExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgExit.Location = new System.Drawing.Point(249, 9);
            this.imgExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgExit.Name = "imgExit";
            this.imgExit.Size = new System.Drawing.Size(31, 24);
            this.imgExit.TabIndex = 21;
            this.imgExit.TabStop = false;
            this.imgExit.Click += new System.EventHandler(this.imgExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CryptoClient.Properties.Resources.justTextTransparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(68, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 50);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // myLoader
            // 
            this.myLoader.Image = global::CryptoClient.Properties.Resources.loaderGray1;
            this.myLoader.Location = new System.Drawing.Point(125, 388);
            this.myLoader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.myLoader.Name = "myLoader";
            this.myLoader.Size = new System.Drawing.Size(50, 56);
            this.myLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.myLoader.TabIndex = 13;
            this.myLoader.TabStop = false;
            // 
            // btnXXTEAAllFiles
            // 
            this.btnXXTEAAllFiles.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnXXTEAAllFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXXTEAAllFiles.FlatAppearance.BorderSize = 0;
            this.btnXXTEAAllFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXXTEAAllFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnXXTEAAllFiles.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnXXTEAAllFiles.Location = new System.Drawing.Point(199, 105);
            this.btnXXTEAAllFiles.Name = "btnXXTEAAllFiles";
            this.btnXXTEAAllFiles.Size = new System.Drawing.Size(81, 42);
            this.btnXXTEAAllFiles.TabIndex = 23;
            this.btnXXTEAAllFiles.Text = "Show all files";
            this.btnXXTEAAllFiles.UseVisualStyleBackColor = false;
            this.btnXXTEAAllFiles.Click += new System.EventHandler(this.btnXXTEAAllFiles_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(294, 10);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(268, 499);
            this.treeView1.TabIndex = 24;
            // 
            // inputAESFolderHashReal
            // 
            this.inputAESFolderHashReal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAESFolderHashReal.Location = new System.Drawing.Point(16, 352);
            this.inputAESFolderHashReal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputAESFolderHashReal.Name = "inputAESFolderHashReal";
            this.inputAESFolderHashReal.ReadOnly = true;
            this.inputAESFolderHashReal.Size = new System.Drawing.Size(229, 13);
            this.inputAESFolderHashReal.TabIndex = 67;
            // 
            // inputAESFolderDecReal
            // 
            this.inputAESFolderDecReal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAESFolderDecReal.Location = new System.Drawing.Point(16, 289);
            this.inputAESFolderDecReal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputAESFolderDecReal.Name = "inputAESFolderDecReal";
            this.inputAESFolderDecReal.ReadOnly = true;
            this.inputAESFolderDecReal.Size = new System.Drawing.Size(229, 13);
            this.inputAESFolderDecReal.TabIndex = 66;
            // 
            // imgHashFolder
            // 
            this.imgHashFolder.BackgroundImage = global::CryptoClient.Properties.Resources.folderBrown;
            this.imgHashFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgHashFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgHashFolder.Location = new System.Drawing.Point(254, 343);
            this.imgHashFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgHashFolder.Name = "imgHashFolder";
            this.imgHashFolder.Size = new System.Drawing.Size(26, 28);
            this.imgHashFolder.TabIndex = 65;
            this.imgHashFolder.TabStop = false;
            this.imgHashFolder.Click += new System.EventHandler(this.imgHashFolder_Click);
            // 
            // imgDecFolder
            // 
            this.imgDecFolder.BackgroundImage = global::CryptoClient.Properties.Resources.folderBrown;
            this.imgDecFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgDecFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgDecFolder.Location = new System.Drawing.Point(254, 281);
            this.imgDecFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgDecFolder.Name = "imgDecFolder";
            this.imgDecFolder.Size = new System.Drawing.Size(26, 28);
            this.imgDecFolder.TabIndex = 64;
            this.imgDecFolder.TabStop = false;
            this.imgDecFolder.Click += new System.EventHandler(this.imgDecFolder_Click);
            // 
            // inputAESFolderEncReal
            // 
            this.inputAESFolderEncReal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAESFolderEncReal.Location = new System.Drawing.Point(16, 223);
            this.inputAESFolderEncReal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputAESFolderEncReal.Name = "inputAESFolderEncReal";
            this.inputAESFolderEncReal.ReadOnly = true;
            this.inputAESFolderEncReal.Size = new System.Drawing.Size(229, 13);
            this.inputAESFolderEncReal.TabIndex = 63;
            // 
            // inputAESFolderEnc
            // 
            this.inputAESFolderEnc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAESFolderEnc.Enabled = false;
            this.inputAESFolderEnc.Location = new System.Drawing.Point(14, 215);
            this.inputAESFolderEnc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputAESFolderEnc.Multiline = true;
            this.inputAESFolderEnc.Name = "inputAESFolderEnc";
            this.inputAESFolderEnc.ReadOnly = true;
            this.inputAESFolderEnc.Size = new System.Drawing.Size(237, 28);
            this.inputAESFolderEnc.TabIndex = 62;
            // 
            // imgEncFolder
            // 
            this.imgEncFolder.BackgroundImage = global::CryptoClient.Properties.Resources.folderBrown;
            this.imgEncFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgEncFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgEncFolder.Location = new System.Drawing.Point(254, 215);
            this.imgEncFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgEncFolder.Name = "imgEncFolder";
            this.imgEncFolder.Size = new System.Drawing.Size(26, 28);
            this.imgEncFolder.TabIndex = 61;
            this.imgEncFolder.TabStop = false;
            this.imgEncFolder.Click += new System.EventHandler(this.imgEncFolder_Click);
            // 
            // cbxHashDefault
            // 
            this.cbxHashDefault.AutoSize = true;
            this.cbxHashDefault.Location = new System.Drawing.Point(199, 322);
            this.cbxHashDefault.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxHashDefault.Name = "cbxHashDefault";
            this.cbxHashDefault.Size = new System.Drawing.Size(89, 17);
            this.cbxHashDefault.TabIndex = 60;
            this.cbxHashDefault.Text = "Default folder";
            this.cbxHashDefault.UseVisualStyleBackColor = true;
            this.cbxHashDefault.CheckedChanged += new System.EventHandler(this.cbxHashDefault_CheckedChanged);
            // 
            // cbxDecDefault
            // 
            this.cbxDecDefault.AutoSize = true;
            this.cbxDecDefault.Location = new System.Drawing.Point(199, 260);
            this.cbxDecDefault.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxDecDefault.Name = "cbxDecDefault";
            this.cbxDecDefault.Size = new System.Drawing.Size(89, 17);
            this.cbxDecDefault.TabIndex = 59;
            this.cbxDecDefault.Text = "Default folder";
            this.cbxDecDefault.UseVisualStyleBackColor = true;
            this.cbxDecDefault.CheckedChanged += new System.EventHandler(this.cbxDecDefault_CheckedChanged);
            // 
            // cbxEncDefault
            // 
            this.cbxEncDefault.AutoSize = true;
            this.cbxEncDefault.Location = new System.Drawing.Point(199, 194);
            this.cbxEncDefault.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxEncDefault.Name = "cbxEncDefault";
            this.cbxEncDefault.Size = new System.Drawing.Size(89, 17);
            this.cbxEncDefault.TabIndex = 58;
            this.cbxEncDefault.Text = "Default folder";
            this.cbxEncDefault.UseVisualStyleBackColor = true;
            this.cbxEncDefault.CheckedChanged += new System.EventHandler(this.cbxEncDefault_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Folder for storing hash files";
            // 
            // inputAESFolderHash
            // 
            this.inputAESFolderHash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAESFolderHash.Enabled = false;
            this.inputAESFolderHash.Location = new System.Drawing.Point(14, 343);
            this.inputAESFolderHash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputAESFolderHash.Multiline = true;
            this.inputAESFolderHash.Name = "inputAESFolderHash";
            this.inputAESFolderHash.ReadOnly = true;
            this.inputAESFolderHash.Size = new System.Drawing.Size(237, 28);
            this.inputAESFolderHash.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Folder for storing decrypted files";
            // 
            // inputAESFolderDec
            // 
            this.inputAESFolderDec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAESFolderDec.Enabled = false;
            this.inputAESFolderDec.Location = new System.Drawing.Point(14, 281);
            this.inputAESFolderDec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputAESFolderDec.Multiline = true;
            this.inputAESFolderDec.Name = "inputAESFolderDec";
            this.inputAESFolderDec.ReadOnly = true;
            this.inputAESFolderDec.Size = new System.Drawing.Size(237, 28);
            this.inputAESFolderDec.TabIndex = 54;
            // 
            // lblAESDecFolder
            // 
            this.lblAESDecFolder.AutoSize = true;
            this.lblAESDecFolder.Location = new System.Drawing.Point(10, 194);
            this.lblAESDecFolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAESDecFolder.Name = "lblAESDecFolder";
            this.lblAESDecFolder.Size = new System.Drawing.Size(156, 13);
            this.lblAESDecFolder.TabIndex = 53;
            this.lblAESDecFolder.Text = "Folder for storing encrypted files";
            // 
            // XXTEAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(570, 515);
            this.Controls.Add(this.inputAESFolderHashReal);
            this.Controls.Add(this.inputAESFolderDecReal);
            this.Controls.Add(this.imgHashFolder);
            this.Controls.Add(this.imgDecFolder);
            this.Controls.Add(this.inputAESFolderEncReal);
            this.Controls.Add(this.inputAESFolderEnc);
            this.Controls.Add(this.imgEncFolder);
            this.Controls.Add(this.cbxHashDefault);
            this.Controls.Add(this.cbxDecDefault);
            this.Controls.Add(this.cbxEncDefault);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputAESFolderHash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputAESFolderDec);
            this.Controls.Add(this.lblAESDecFolder);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnXXTEAAllFiles);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.imgExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressDone);
            this.Controls.Add(this.lblXXTEATitle);
            this.Controls.Add(this.myLoader);
            this.Controls.Add(this.cbxXXTEAPar);
            this.Controls.Add(this.lblDecXXTEADone);
            this.Controls.Add(this.lblEncXXTEADone);
            this.Controls.Add(this.btnXXTEADec);
            this.Controls.Add(this.btnXXTEAEnc);
            this.Controls.Add(this.inputXXTEAKey);
            this.Controls.Add(this.lblXXTEAKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "XXTEAForm";
            this.Text = "XXTEA";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XXTEAForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.XXTEAForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XXTEAForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLoader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHashFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDecFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEncFolder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXXTEAKey;
        private System.Windows.Forms.TextBox inputXXTEAKey;
        private System.Windows.Forms.Button btnXXTEAEnc;
        private System.Windows.Forms.Button btnXXTEADec;
        private System.Windows.Forms.Label lblEncXXTEADone;
        private System.Windows.Forms.Label lblDecXXTEADone;
        private System.Windows.Forms.CheckBox cbxXXTEAPar;
        private System.Windows.Forms.PictureBox myLoader;
        private System.Windows.Forms.Label lblXXTEATitle;
        private System.Windows.Forms.ProgressBar progressDone;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox imgExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnXXTEAAllFiles;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox inputAESFolderHashReal;
        private System.Windows.Forms.TextBox inputAESFolderDecReal;
        private System.Windows.Forms.PictureBox imgHashFolder;
        private System.Windows.Forms.PictureBox imgDecFolder;
        private System.Windows.Forms.TextBox inputAESFolderEncReal;
        private System.Windows.Forms.TextBox inputAESFolderEnc;
        private System.Windows.Forms.PictureBox imgEncFolder;
        private System.Windows.Forms.CheckBox cbxHashDefault;
        private System.Windows.Forms.CheckBox cbxDecDefault;
        private System.Windows.Forms.CheckBox cbxEncDefault;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputAESFolderHash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputAESFolderDec;
        private System.Windows.Forms.Label lblAESDecFolder;
    }
}