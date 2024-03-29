﻿namespace CryptoClient.Forms
{
    partial class AESForm
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
            this.lblAesKey = new System.Windows.Forms.Label();
            this.lblAesIV = new System.Windows.Forms.Label();
            this.inputAesKey = new System.Windows.Forms.TextBox();
            this.inputAesIV = new System.Windows.Forms.TextBox();
            this.btnAesEnc = new System.Windows.Forms.Button();
            this.btnAesDec = new System.Windows.Forms.Button();
            this.lblAESTitle = new System.Windows.Forms.Label();
            this.cbxAESPar = new System.Windows.Forms.CheckBox();
            this.lblEncAESDone = new System.Windows.Forms.Label();
            this.lblDecAESDone = new System.Windows.Forms.Label();
            this.progressDone = new System.Windows.Forms.ProgressBar();
            this.btnAesAllFiles = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblAESDecFolder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputAESFolderDec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputAESFolderHash = new System.Windows.Forms.TextBox();
            this.cbxEncDefault = new System.Windows.Forms.CheckBox();
            this.cbxDecDefault = new System.Windows.Forms.CheckBox();
            this.cbxHashDefault = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imgExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.myLoader = new System.Windows.Forms.PictureBox();
            this.imgEncFolder = new System.Windows.Forms.PictureBox();
            this.inputAESFolderEnc = new System.Windows.Forms.TextBox();
            this.inputAESFolderEncReal = new System.Windows.Forms.TextBox();
            this.imgDecFolder = new System.Windows.Forms.PictureBox();
            this.imgHashFolder = new System.Windows.Forms.PictureBox();
            this.inputAESFolderDecReal = new System.Windows.Forms.TextBox();
            this.inputAESFolderHashReal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLoader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEncFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDecFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHashFolder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAesKey
            // 
            this.lblAesKey.AutoSize = true;
            this.lblAesKey.Location = new System.Drawing.Point(15, 116);
            this.lblAesKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAesKey.Name = "lblAesKey";
            this.lblAesKey.Size = new System.Drawing.Size(121, 16);
            this.lblAesKey.TabIndex = 0;
            this.lblAesKey.Text = "Key (32 characters)";
            // 
            // lblAesIV
            // 
            this.lblAesIV.AutoSize = true;
            this.lblAesIV.Location = new System.Drawing.Point(15, 187);
            this.lblAesIV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAesIV.Name = "lblAesIV";
            this.lblAesIV.Size = new System.Drawing.Size(110, 16);
            this.lblAesIV.TabIndex = 1;
            this.lblAesIV.Text = "IV (16 characters)";
            // 
            // inputAesKey
            // 
            this.inputAesKey.Location = new System.Drawing.Point(18, 136);
            this.inputAesKey.Margin = new System.Windows.Forms.Padding(4);
            this.inputAesKey.Multiline = true;
            this.inputAesKey.Name = "inputAesKey";
            this.inputAesKey.Size = new System.Drawing.Size(357, 40);
            this.inputAesKey.TabIndex = 2;
            // 
            // inputAesIV
            // 
            this.inputAesIV.Location = new System.Drawing.Point(18, 208);
            this.inputAesIV.Margin = new System.Windows.Forms.Padding(4);
            this.inputAesIV.Multiline = true;
            this.inputAesIV.Name = "inputAesIV";
            this.inputAesIV.Size = new System.Drawing.Size(225, 40);
            this.inputAesIV.TabIndex = 3;
            // 
            // btnAesEnc
            // 
            this.btnAesEnc.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAesEnc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAesEnc.FlatAppearance.BorderSize = 0;
            this.btnAesEnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAesEnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAesEnc.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnAesEnc.Location = new System.Drawing.Point(20, 571);
            this.btnAesEnc.Margin = new System.Windows.Forms.Padding(4);
            this.btnAesEnc.Name = "btnAesEnc";
            this.btnAesEnc.Size = new System.Drawing.Size(105, 40);
            this.btnAesEnc.TabIndex = 4;
            this.btnAesEnc.Text = "Encrypt";
            this.btnAesEnc.UseVisualStyleBackColor = false;
            this.btnAesEnc.Click += new System.EventHandler(this.btnAesEnc_Click);
            // 
            // btnAesDec
            // 
            this.btnAesDec.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAesDec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAesDec.FlatAppearance.BorderSize = 0;
            this.btnAesDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAesDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAesDec.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnAesDec.Location = new System.Drawing.Point(265, 572);
            this.btnAesDec.Margin = new System.Windows.Forms.Padding(4);
            this.btnAesDec.Name = "btnAesDec";
            this.btnAesDec.Size = new System.Drawing.Size(110, 40);
            this.btnAesDec.TabIndex = 5;
            this.btnAesDec.Text = "Decrypt";
            this.btnAesDec.UseVisualStyleBackColor = false;
            this.btnAesDec.Click += new System.EventHandler(this.btnAesDec_Click);
            // 
            // lblAESTitle
            // 
            this.lblAESTitle.AutoSize = true;
            this.lblAESTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAESTitle.Location = new System.Drawing.Point(156, 79);
            this.lblAESTitle.Name = "lblAESTitle";
            this.lblAESTitle.Size = new System.Drawing.Size(74, 32);
            this.lblAESTitle.TabIndex = 6;
            this.lblAESTitle.Text = "AES";
            // 
            // cbxAESPar
            // 
            this.cbxAESPar.AutoSize = true;
            this.cbxAESPar.Location = new System.Drawing.Point(152, 266);
            this.cbxAESPar.Name = "cbxAESPar";
            this.cbxAESPar.Size = new System.Drawing.Size(113, 20);
            this.cbxAESPar.TabIndex = 7;
            this.cbxAESPar.Text = "Parallelization";
            this.cbxAESPar.UseVisualStyleBackColor = true;
            // 
            // lblEncAESDone
            // 
            this.lblEncAESDone.AutoSize = true;
            this.lblEncAESDone.Location = new System.Drawing.Point(11, 657);
            this.lblEncAESDone.Name = "lblEncAESDone";
            this.lblEncAESDone.Size = new System.Drawing.Size(145, 16);
            this.lblEncAESDone.TabIndex = 8;
            this.lblEncAESDone.Text = "Encryption complete in ";
            // 
            // lblDecAESDone
            // 
            this.lblDecAESDone.AutoSize = true;
            this.lblDecAESDone.Location = new System.Drawing.Point(11, 684);
            this.lblDecAESDone.Name = "lblDecAESDone";
            this.lblDecAESDone.Size = new System.Drawing.Size(147, 16);
            this.lblDecAESDone.TabIndex = 9;
            this.lblDecAESDone.Text = "Decryption complete in ";
            // 
            // progressDone
            // 
            this.progressDone.Location = new System.Drawing.Point(141, 618);
            this.progressDone.Name = "progressDone";
            this.progressDone.Size = new System.Drawing.Size(113, 23);
            this.progressDone.TabIndex = 11;
            // 
            // btnAesAllFiles
            // 
            this.btnAesAllFiles.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAesAllFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAesAllFiles.FlatAppearance.BorderSize = 0;
            this.btnAesAllFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAesAllFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAesAllFiles.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnAesAllFiles.Location = new System.Drawing.Point(265, 187);
            this.btnAesAllFiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnAesAllFiles.Name = "btnAesAllFiles";
            this.btnAesAllFiles.Size = new System.Drawing.Size(110, 61);
            this.btnAesAllFiles.TabIndex = 17;
            this.btnAesAllFiles.Text = "Show all files";
            this.btnAesAllFiles.UseVisualStyleBackColor = false;
            this.btnAesAllFiles.Click += new System.EventHandler(this.btnAesAllFiles_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(399, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(374, 694);
            this.treeView1.TabIndex = 18;
            // 
            // lblAESDecFolder
            // 
            this.lblAESDecFolder.AutoSize = true;
            this.lblAESDecFolder.Location = new System.Drawing.Point(15, 305);
            this.lblAESDecFolder.Name = "lblAESDecFolder";
            this.lblAESDecFolder.Size = new System.Drawing.Size(197, 16);
            this.lblAESDecFolder.TabIndex = 22;
            this.lblAESDecFolder.Text = "Folder for storing encrypted files";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Folder for storing decrypted files";
            // 
            // inputAESFolderDec
            // 
            this.inputAESFolderDec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAESFolderDec.Enabled = false;
            this.inputAESFolderDec.Location = new System.Drawing.Point(18, 412);
            this.inputAESFolderDec.Multiline = true;
            this.inputAESFolderDec.Name = "inputAESFolderDec";
            this.inputAESFolderDec.ReadOnly = true;
            this.inputAESFolderDec.Size = new System.Drawing.Size(316, 35);
            this.inputAESFolderDec.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Folder for storing hash files";
            // 
            // inputAESFolderHash
            // 
            this.inputAESFolderHash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAESFolderHash.Enabled = false;
            this.inputAESFolderHash.Location = new System.Drawing.Point(18, 488);
            this.inputAESFolderHash.Multiline = true;
            this.inputAESFolderHash.Name = "inputAESFolderHash";
            this.inputAESFolderHash.ReadOnly = true;
            this.inputAESFolderHash.Size = new System.Drawing.Size(316, 35);
            this.inputAESFolderHash.TabIndex = 25;
            // 
            // cbxEncDefault
            // 
            this.cbxEncDefault.AutoSize = true;
            this.cbxEncDefault.Location = new System.Drawing.Point(267, 305);
            this.cbxEncDefault.Name = "cbxEncDefault";
            this.cbxEncDefault.Size = new System.Drawing.Size(108, 20);
            this.cbxEncDefault.TabIndex = 27;
            this.cbxEncDefault.Text = "Default folder";
            this.cbxEncDefault.UseVisualStyleBackColor = true;
            this.cbxEncDefault.CheckedChanged += new System.EventHandler(this.cbxEncDefault_CheckedChanged);
            // 
            // cbxDecDefault
            // 
            this.cbxDecDefault.AutoSize = true;
            this.cbxDecDefault.Location = new System.Drawing.Point(267, 386);
            this.cbxDecDefault.Name = "cbxDecDefault";
            this.cbxDecDefault.Size = new System.Drawing.Size(108, 20);
            this.cbxDecDefault.TabIndex = 28;
            this.cbxDecDefault.Text = "Default folder";
            this.cbxDecDefault.UseVisualStyleBackColor = true;
            this.cbxDecDefault.CheckedChanged += new System.EventHandler(this.cbxDecDefault_CheckedChanged);
            // 
            // cbxHashDefault
            // 
            this.cbxHashDefault.AutoSize = true;
            this.cbxHashDefault.Location = new System.Drawing.Point(267, 459);
            this.cbxHashDefault.Name = "cbxHashDefault";
            this.cbxHashDefault.Size = new System.Drawing.Size(108, 20);
            this.cbxHashDefault.TabIndex = 29;
            this.cbxHashDefault.Text = "Default folder";
            this.cbxHashDefault.UseVisualStyleBackColor = true;
            this.cbxHashDefault.CheckedChanged += new System.EventHandler(this.cbxHashDefault_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CryptoClient.Properties.Resources.justLogoTransparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 62);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // imgExit
            // 
            this.imgExit.BackgroundImage = global::CryptoClient.Properties.Resources.XredTransparent;
            this.imgExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgExit.Location = new System.Drawing.Point(334, 12);
            this.imgExit.Name = "imgExit";
            this.imgExit.Size = new System.Drawing.Size(41, 30);
            this.imgExit.TabIndex = 15;
            this.imgExit.TabStop = false;
            this.imgExit.Click += new System.EventHandler(this.imgExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CryptoClient.Properties.Resources.justTextTransparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(92, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 62);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // myLoader
            // 
            this.myLoader.BackColor = System.Drawing.Color.Transparent;
            this.myLoader.Image = global::CryptoClient.Properties.Resources.loaderGray1;
            this.myLoader.Location = new System.Drawing.Point(162, 543);
            this.myLoader.Name = "myLoader";
            this.myLoader.Size = new System.Drawing.Size(66, 69);
            this.myLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.myLoader.TabIndex = 10;
            this.myLoader.TabStop = false;
            // 
            // imgEncFolder
            // 
            this.imgEncFolder.BackgroundImage = global::CryptoClient.Properties.Resources.folderBrown;
            this.imgEncFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgEncFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgEncFolder.Location = new System.Drawing.Point(340, 331);
            this.imgEncFolder.Name = "imgEncFolder";
            this.imgEncFolder.Size = new System.Drawing.Size(35, 35);
            this.imgEncFolder.TabIndex = 31;
            this.imgEncFolder.TabStop = false;
            this.imgEncFolder.Click += new System.EventHandler(this.imgEncFolder_Click);
            // 
            // inputAESFolderEnc
            // 
            this.inputAESFolderEnc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAESFolderEnc.Enabled = false;
            this.inputAESFolderEnc.Location = new System.Drawing.Point(18, 331);
            this.inputAESFolderEnc.Multiline = true;
            this.inputAESFolderEnc.Name = "inputAESFolderEnc";
            this.inputAESFolderEnc.ReadOnly = true;
            this.inputAESFolderEnc.Size = new System.Drawing.Size(316, 35);
            this.inputAESFolderEnc.TabIndex = 32;
            // 
            // inputAESFolderEncReal
            // 
            this.inputAESFolderEncReal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAESFolderEncReal.Location = new System.Drawing.Point(22, 340);
            this.inputAESFolderEncReal.Name = "inputAESFolderEncReal";
            this.inputAESFolderEncReal.ReadOnly = true;
            this.inputAESFolderEncReal.Size = new System.Drawing.Size(305, 15);
            this.inputAESFolderEncReal.TabIndex = 33;
            // 
            // imgDecFolder
            // 
            this.imgDecFolder.BackgroundImage = global::CryptoClient.Properties.Resources.folderBrown;
            this.imgDecFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgDecFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgDecFolder.Location = new System.Drawing.Point(340, 412);
            this.imgDecFolder.Name = "imgDecFolder";
            this.imgDecFolder.Size = new System.Drawing.Size(35, 35);
            this.imgDecFolder.TabIndex = 34;
            this.imgDecFolder.TabStop = false;
            this.imgDecFolder.Click += new System.EventHandler(this.imgDecFolder_Click);
            // 
            // imgHashFolder
            // 
            this.imgHashFolder.BackgroundImage = global::CryptoClient.Properties.Resources.folderBrown;
            this.imgHashFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgHashFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgHashFolder.Location = new System.Drawing.Point(340, 488);
            this.imgHashFolder.Name = "imgHashFolder";
            this.imgHashFolder.Size = new System.Drawing.Size(35, 35);
            this.imgHashFolder.TabIndex = 35;
            this.imgHashFolder.TabStop = false;
            this.imgHashFolder.Click += new System.EventHandler(this.imgHashFolder_Click);
            // 
            // inputAESFolderDecReal
            // 
            this.inputAESFolderDecReal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAESFolderDecReal.Location = new System.Drawing.Point(22, 422);
            this.inputAESFolderDecReal.Name = "inputAESFolderDecReal";
            this.inputAESFolderDecReal.ReadOnly = true;
            this.inputAESFolderDecReal.Size = new System.Drawing.Size(305, 15);
            this.inputAESFolderDecReal.TabIndex = 36;
            // 
            // inputAESFolderHashReal
            // 
            this.inputAESFolderHashReal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAESFolderHashReal.Location = new System.Drawing.Point(22, 499);
            this.inputAESFolderHashReal.Name = "inputAESFolderHashReal";
            this.inputAESFolderHashReal.ReadOnly = true;
            this.inputAESFolderHashReal.Size = new System.Drawing.Size(305, 15);
            this.inputAESFolderHashReal.TabIndex = 37;
            // 
            // AESForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(785, 709);
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
            this.Controls.Add(this.btnAesAllFiles);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.imgExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressDone);
            this.Controls.Add(this.myLoader);
            this.Controls.Add(this.lblDecAESDone);
            this.Controls.Add(this.lblEncAESDone);
            this.Controls.Add(this.cbxAESPar);
            this.Controls.Add(this.lblAESTitle);
            this.Controls.Add(this.btnAesDec);
            this.Controls.Add(this.btnAesEnc);
            this.Controls.Add(this.inputAesIV);
            this.Controls.Add(this.inputAesKey);
            this.Controls.Add(this.lblAesIV);
            this.Controls.Add(this.lblAesKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AESForm";
            this.Text = "AES";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AESForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AESForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AESForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLoader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEncFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDecFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHashFolder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAesKey;
        private System.Windows.Forms.Label lblAesIV;
        private System.Windows.Forms.TextBox inputAesKey;
        private System.Windows.Forms.TextBox inputAesIV;
        private System.Windows.Forms.Button btnAesEnc;
        private System.Windows.Forms.Button btnAesDec;
        private System.Windows.Forms.Label lblAESTitle;
        private System.Windows.Forms.CheckBox cbxAESPar;
        private System.Windows.Forms.Label lblEncAESDone;
        private System.Windows.Forms.Label lblDecAESDone;
        private System.Windows.Forms.PictureBox myLoader;
        private System.Windows.Forms.ProgressBar progressDone;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox imgExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAesAllFiles;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblAESDecFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputAESFolderDec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputAESFolderHash;
        private System.Windows.Forms.CheckBox cbxEncDefault;
        private System.Windows.Forms.CheckBox cbxDecDefault;
        private System.Windows.Forms.CheckBox cbxHashDefault;
        private System.Windows.Forms.PictureBox imgEncFolder;
        private System.Windows.Forms.TextBox inputAESFolderEnc;
        private System.Windows.Forms.TextBox inputAESFolderEncReal;
        private System.Windows.Forms.PictureBox imgDecFolder;
        private System.Windows.Forms.PictureBox imgHashFolder;
        private System.Windows.Forms.TextBox inputAESFolderDecReal;
        private System.Windows.Forms.TextBox inputAESFolderHashReal;
    }
}