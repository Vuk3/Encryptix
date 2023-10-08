namespace CryptoClient.Forms
{
    partial class RC6Form
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
            this.lblRC6Key = new System.Windows.Forms.Label();
            this.inputRC6Key = new System.Windows.Forms.TextBox();
            this.btnRC6Encrypt = new System.Windows.Forms.Button();
            this.btnRC6Decrypt = new System.Windows.Forms.Button();
            this.lblEncRC6Done = new System.Windows.Forms.Label();
            this.lblDecRC6Done = new System.Windows.Forms.Label();
            this.cbxRC6Par = new System.Windows.Forms.CheckBox();
            this.lblRC6Title = new System.Windows.Forms.Label();
            this.progressDone = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imgExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.myLoader = new System.Windows.Forms.PictureBox();
            this.btnRC6AllFiles = new System.Windows.Forms.Button();
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
            // lblRC6Key
            // 
            this.lblRC6Key.AutoSize = true;
            this.lblRC6Key.Location = new System.Drawing.Point(15, 107);
            this.lblRC6Key.Name = "lblRC6Key";
            this.lblRC6Key.Size = new System.Drawing.Size(121, 16);
            this.lblRC6Key.TabIndex = 0;
            this.lblRC6Key.Text = "Key (16 characters)";
            // 
            // inputRC6Key
            // 
            this.inputRC6Key.Location = new System.Drawing.Point(18, 134);
            this.inputRC6Key.Multiline = true;
            this.inputRC6Key.Name = "inputRC6Key";
            this.inputRC6Key.Size = new System.Drawing.Size(237, 43);
            this.inputRC6Key.TabIndex = 1;
            // 
            // btnRC6Encrypt
            // 
            this.btnRC6Encrypt.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRC6Encrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRC6Encrypt.FlatAppearance.BorderSize = 0;
            this.btnRC6Encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRC6Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRC6Encrypt.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnRC6Encrypt.Location = new System.Drawing.Point(18, 478);
            this.btnRC6Encrypt.Name = "btnRC6Encrypt";
            this.btnRC6Encrypt.Size = new System.Drawing.Size(105, 40);
            this.btnRC6Encrypt.TabIndex = 2;
            this.btnRC6Encrypt.Text = "Encrypt";
            this.btnRC6Encrypt.UseVisualStyleBackColor = false;
            this.btnRC6Encrypt.Click += new System.EventHandler(this.btnRC6Encrypt_Click);
            // 
            // btnRC6Decrypt
            // 
            this.btnRC6Decrypt.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRC6Decrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRC6Decrypt.FlatAppearance.BorderSize = 0;
            this.btnRC6Decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRC6Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRC6Decrypt.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnRC6Decrypt.Location = new System.Drawing.Point(269, 478);
            this.btnRC6Decrypt.Name = "btnRC6Decrypt";
            this.btnRC6Decrypt.Size = new System.Drawing.Size(105, 40);
            this.btnRC6Decrypt.TabIndex = 3;
            this.btnRC6Decrypt.Text = "Decrypt";
            this.btnRC6Decrypt.UseVisualStyleBackColor = false;
            this.btnRC6Decrypt.Click += new System.EventHandler(this.btnRC6Decrypt_Click);
            // 
            // lblEncRC6Done
            // 
            this.lblEncRC6Done.AutoSize = true;
            this.lblEncRC6Done.Location = new System.Drawing.Point(14, 572);
            this.lblEncRC6Done.Name = "lblEncRC6Done";
            this.lblEncRC6Done.Size = new System.Drawing.Size(145, 16);
            this.lblEncRC6Done.TabIndex = 9;
            this.lblEncRC6Done.Text = "Encryption complete in ";
            // 
            // lblDecRC6Done
            // 
            this.lblDecRC6Done.AutoSize = true;
            this.lblDecRC6Done.Location = new System.Drawing.Point(14, 596);
            this.lblDecRC6Done.Name = "lblDecRC6Done";
            this.lblDecRC6Done.Size = new System.Drawing.Size(147, 16);
            this.lblDecRC6Done.TabIndex = 10;
            this.lblDecRC6Done.Text = "Decryption complete in ";
            // 
            // cbxRC6Par
            // 
            this.cbxRC6Par.AutoSize = true;
            this.cbxRC6Par.Location = new System.Drawing.Point(138, 190);
            this.cbxRC6Par.Name = "cbxRC6Par";
            this.cbxRC6Par.Size = new System.Drawing.Size(113, 20);
            this.cbxRC6Par.TabIndex = 11;
            this.cbxRC6Par.Text = "Parallelization";
            this.cbxRC6Par.UseVisualStyleBackColor = true;
            // 
            // lblRC6Title
            // 
            this.lblRC6Title.AutoSize = true;
            this.lblRC6Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRC6Title.Location = new System.Drawing.Point(158, 78);
            this.lblRC6Title.Name = "lblRC6Title";
            this.lblRC6Title.Size = new System.Drawing.Size(73, 32);
            this.lblRC6Title.TabIndex = 13;
            this.lblRC6Title.Text = "RC6";
            // 
            // progressDone
            // 
            this.progressDone.Location = new System.Drawing.Point(142, 533);
            this.progressDone.Name = "progressDone";
            this.progressDone.Size = new System.Drawing.Size(113, 23);
            this.progressDone.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CryptoClient.Properties.Resources.justLogoTransparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(2, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 62);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // imgExit
            // 
            this.imgExit.BackgroundImage = global::CryptoClient.Properties.Resources.XredTransparent;
            this.imgExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgExit.Location = new System.Drawing.Point(333, 10);
            this.imgExit.Name = "imgExit";
            this.imgExit.Size = new System.Drawing.Size(41, 30);
            this.imgExit.TabIndex = 18;
            this.imgExit.TabStop = false;
            this.imgExit.Click += new System.EventHandler(this.imgExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CryptoClient.Properties.Resources.justTextTransparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(91, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 62);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // myLoader
            // 
            this.myLoader.Image = global::CryptoClient.Properties.Resources.loaderGray1;
            this.myLoader.Location = new System.Drawing.Point(164, 449);
            this.myLoader.Name = "myLoader";
            this.myLoader.Size = new System.Drawing.Size(66, 69);
            this.myLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.myLoader.TabIndex = 12;
            this.myLoader.TabStop = false;
            // 
            // btnRC6AllFiles
            // 
            this.btnRC6AllFiles.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRC6AllFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRC6AllFiles.FlatAppearance.BorderSize = 0;
            this.btnRC6AllFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRC6AllFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRC6AllFiles.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnRC6AllFiles.Location = new System.Drawing.Point(266, 115);
            this.btnRC6AllFiles.Margin = new System.Windows.Forms.Padding(4);
            this.btnRC6AllFiles.Name = "btnRC6AllFiles";
            this.btnRC6AllFiles.Size = new System.Drawing.Size(108, 62);
            this.btnRC6AllFiles.TabIndex = 20;
            this.btnRC6AllFiles.Text = "Show all files";
            this.btnRC6AllFiles.UseVisualStyleBackColor = false;
            this.btnRC6AllFiles.Click += new System.EventHandler(this.btnRC6AllFiles_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(404, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(363, 606);
            this.treeView1.TabIndex = 21;
            // 
            // inputAESFolderHashReal
            // 
            this.inputAESFolderHashReal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAESFolderHashReal.Location = new System.Drawing.Point(22, 412);
            this.inputAESFolderHashReal.Name = "inputAESFolderHashReal";
            this.inputAESFolderHashReal.ReadOnly = true;
            this.inputAESFolderHashReal.Size = new System.Drawing.Size(305, 15);
            this.inputAESFolderHashReal.TabIndex = 52;
            // 
            // inputAESFolderDecReal
            // 
            this.inputAESFolderDecReal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAESFolderDecReal.Location = new System.Drawing.Point(22, 335);
            this.inputAESFolderDecReal.Name = "inputAESFolderDecReal";
            this.inputAESFolderDecReal.ReadOnly = true;
            this.inputAESFolderDecReal.Size = new System.Drawing.Size(305, 15);
            this.inputAESFolderDecReal.TabIndex = 51;
            // 
            // imgHashFolder
            // 
            this.imgHashFolder.BackgroundImage = global::CryptoClient.Properties.Resources.folderBrown;
            this.imgHashFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgHashFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgHashFolder.Location = new System.Drawing.Point(339, 401);
            this.imgHashFolder.Name = "imgHashFolder";
            this.imgHashFolder.Size = new System.Drawing.Size(35, 35);
            this.imgHashFolder.TabIndex = 50;
            this.imgHashFolder.TabStop = false;
            this.imgHashFolder.Click += new System.EventHandler(this.imgHashFolder_Click);
            // 
            // imgDecFolder
            // 
            this.imgDecFolder.BackgroundImage = global::CryptoClient.Properties.Resources.folderBrown;
            this.imgDecFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgDecFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgDecFolder.Location = new System.Drawing.Point(339, 325);
            this.imgDecFolder.Name = "imgDecFolder";
            this.imgDecFolder.Size = new System.Drawing.Size(35, 35);
            this.imgDecFolder.TabIndex = 49;
            this.imgDecFolder.TabStop = false;
            this.imgDecFolder.Click += new System.EventHandler(this.imgDecFolder_Click);
            // 
            // inputAESFolderEncReal
            // 
            this.inputAESFolderEncReal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAESFolderEncReal.Location = new System.Drawing.Point(22, 253);
            this.inputAESFolderEncReal.Name = "inputAESFolderEncReal";
            this.inputAESFolderEncReal.ReadOnly = true;
            this.inputAESFolderEncReal.Size = new System.Drawing.Size(305, 15);
            this.inputAESFolderEncReal.TabIndex = 48;
            // 
            // inputAESFolderEnc
            // 
            this.inputAESFolderEnc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAESFolderEnc.Enabled = false;
            this.inputAESFolderEnc.Location = new System.Drawing.Point(18, 244);
            this.inputAESFolderEnc.Multiline = true;
            this.inputAESFolderEnc.Name = "inputAESFolderEnc";
            this.inputAESFolderEnc.ReadOnly = true;
            this.inputAESFolderEnc.Size = new System.Drawing.Size(316, 35);
            this.inputAESFolderEnc.TabIndex = 47;
            // 
            // imgEncFolder
            // 
            this.imgEncFolder.BackgroundImage = global::CryptoClient.Properties.Resources.folderBrown;
            this.imgEncFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgEncFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgEncFolder.Location = new System.Drawing.Point(339, 244);
            this.imgEncFolder.Name = "imgEncFolder";
            this.imgEncFolder.Size = new System.Drawing.Size(35, 35);
            this.imgEncFolder.TabIndex = 46;
            this.imgEncFolder.TabStop = false;
            this.imgEncFolder.Click += new System.EventHandler(this.imgEncFolder_Click);
            // 
            // cbxHashDefault
            // 
            this.cbxHashDefault.AutoSize = true;
            this.cbxHashDefault.Location = new System.Drawing.Point(266, 375);
            this.cbxHashDefault.Name = "cbxHashDefault";
            this.cbxHashDefault.Size = new System.Drawing.Size(108, 20);
            this.cbxHashDefault.TabIndex = 45;
            this.cbxHashDefault.Text = "Default folder";
            this.cbxHashDefault.UseVisualStyleBackColor = true;
            this.cbxHashDefault.CheckedChanged += new System.EventHandler(this.cbxHashDefault_CheckedChanged);
            // 
            // cbxDecDefault
            // 
            this.cbxDecDefault.AutoSize = true;
            this.cbxDecDefault.Location = new System.Drawing.Point(266, 299);
            this.cbxDecDefault.Name = "cbxDecDefault";
            this.cbxDecDefault.Size = new System.Drawing.Size(108, 20);
            this.cbxDecDefault.TabIndex = 44;
            this.cbxDecDefault.Text = "Default folder";
            this.cbxDecDefault.UseVisualStyleBackColor = true;
            this.cbxDecDefault.CheckedChanged += new System.EventHandler(this.cbxDecDefault_CheckedChanged);
            // 
            // cbxEncDefault
            // 
            this.cbxEncDefault.AutoSize = true;
            this.cbxEncDefault.Location = new System.Drawing.Point(256, 218);
            this.cbxEncDefault.Name = "cbxEncDefault";
            this.cbxEncDefault.Size = new System.Drawing.Size(108, 20);
            this.cbxEncDefault.TabIndex = 43;
            this.cbxEncDefault.Text = "Default folder";
            this.cbxEncDefault.UseVisualStyleBackColor = true;
            this.cbxEncDefault.CheckedChanged += new System.EventHandler(this.cbxEncDefault_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Folder for storing hash files";
            // 
            // inputAESFolderHash
            // 
            this.inputAESFolderHash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAESFolderHash.Enabled = false;
            this.inputAESFolderHash.Location = new System.Drawing.Point(18, 401);
            this.inputAESFolderHash.Multiline = true;
            this.inputAESFolderHash.Name = "inputAESFolderHash";
            this.inputAESFolderHash.ReadOnly = true;
            this.inputAESFolderHash.Size = new System.Drawing.Size(316, 35);
            this.inputAESFolderHash.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Folder for storing decrypted files";
            // 
            // inputAESFolderDec
            // 
            this.inputAESFolderDec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputAESFolderDec.Enabled = false;
            this.inputAESFolderDec.Location = new System.Drawing.Point(18, 325);
            this.inputAESFolderDec.Multiline = true;
            this.inputAESFolderDec.Name = "inputAESFolderDec";
            this.inputAESFolderDec.ReadOnly = true;
            this.inputAESFolderDec.Size = new System.Drawing.Size(316, 35);
            this.inputAESFolderDec.TabIndex = 39;
            // 
            // lblAESDecFolder
            // 
            this.lblAESDecFolder.AutoSize = true;
            this.lblAESDecFolder.Location = new System.Drawing.Point(15, 218);
            this.lblAESDecFolder.Name = "lblAESDecFolder";
            this.lblAESDecFolder.Size = new System.Drawing.Size(197, 16);
            this.lblAESDecFolder.TabIndex = 38;
            this.lblAESDecFolder.Text = "Folder for storing encrypted files";
            // 
            // RC6Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(772, 628);
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
            this.Controls.Add(this.btnRC6AllFiles);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.imgExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressDone);
            this.Controls.Add(this.lblRC6Title);
            this.Controls.Add(this.myLoader);
            this.Controls.Add(this.cbxRC6Par);
            this.Controls.Add(this.lblDecRC6Done);
            this.Controls.Add(this.lblEncRC6Done);
            this.Controls.Add(this.btnRC6Decrypt);
            this.Controls.Add(this.btnRC6Encrypt);
            this.Controls.Add(this.inputRC6Key);
            this.Controls.Add(this.lblRC6Key);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RC6Form";
            this.Text = "RC6";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RC6Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RC6Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RC6Form_MouseUp);
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

        private System.Windows.Forms.Label lblRC6Key;
        private System.Windows.Forms.TextBox inputRC6Key;
        private System.Windows.Forms.Button btnRC6Encrypt;
        private System.Windows.Forms.Button btnRC6Decrypt;
        private System.Windows.Forms.Label lblEncRC6Done;
        private System.Windows.Forms.Label lblDecRC6Done;
        private System.Windows.Forms.CheckBox cbxRC6Par;
        private System.Windows.Forms.PictureBox myLoader;
        private System.Windows.Forms.Label lblRC6Title;
        private System.Windows.Forms.ProgressBar progressDone;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox imgExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRC6AllFiles;
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