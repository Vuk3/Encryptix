namespace CryptoClient
{
    partial class MainForm
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
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.lblTotalFiles = new System.Windows.Forms.Label();
            this.btnAes = new System.Windows.Forms.Button();
            this.btnRC6 = new System.Windows.Forms.Button();
            this.btnXXTEA = new System.Windows.Forms.Button();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOneFile = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imgExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.myLoader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseFolder.Location = new System.Drawing.Point(96, 180);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(90, 41);
            this.btnChooseFolder.TabIndex = 0;
            this.btnChooseFolder.Text = "Choose folder";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // lblTotalFiles
            // 
            this.lblTotalFiles.AutoSize = true;
            this.lblTotalFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotalFiles.Location = new System.Drawing.Point(16, 239);
            this.lblTotalFiles.Name = "lblTotalFiles";
            this.lblTotalFiles.Size = new System.Drawing.Size(205, 15);
            this.lblTotalFiles.TabIndex = 1;
            this.lblTotalFiles.Text = "You have successfully read a total of ";
            this.lblTotalFiles.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAes
            // 
            this.btnAes.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAes.FlatAppearance.BorderSize = 0;
            this.btnAes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAes.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnAes.Location = new System.Drawing.Point(0, 257);
            this.btnAes.Name = "btnAes";
            this.btnAes.Size = new System.Drawing.Size(94, 68);
            this.btnAes.TabIndex = 2;
            this.btnAes.Text = "AES";
            this.btnAes.UseVisualStyleBackColor = false;
            this.btnAes.Click += new System.EventHandler(this.btnAes_Click);
            // 
            // btnRC6
            // 
            this.btnRC6.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnRC6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRC6.FlatAppearance.BorderSize = 0;
            this.btnRC6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRC6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRC6.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnRC6.Location = new System.Drawing.Point(96, 257);
            this.btnRC6.Name = "btnRC6";
            this.btnRC6.Size = new System.Drawing.Size(94, 68);
            this.btnRC6.TabIndex = 3;
            this.btnRC6.Text = "RC6";
            this.btnRC6.UseVisualStyleBackColor = false;
            this.btnRC6.Click += new System.EventHandler(this.btnRC6_Click);
            // 
            // btnXXTEA
            // 
            this.btnXXTEA.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnXXTEA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXXTEA.FlatAppearance.BorderSize = 0;
            this.btnXXTEA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXXTEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnXXTEA.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnXXTEA.Location = new System.Drawing.Point(192, 257);
            this.btnXXTEA.Name = "btnXXTEA";
            this.btnXXTEA.Size = new System.Drawing.Size(94, 68);
            this.btnXXTEA.TabIndex = 4;
            this.btnXXTEA.Text = "XXTEA";
            this.btnXXTEA.UseVisualStyleBackColor = false;
            this.btnXXTEA.Click += new System.EventHandler(this.btnXXTEA_Click);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMainTitle.Location = new System.Drawing.Point(64, 88);
            this.lblMainTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(160, 24);
            this.lblMainTitle.TabIndex = 6;
            this.lblMainTitle.Text = "Confidently Guard";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(71, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Your Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(45, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select the files to encrypt/decrypt";
            // 
            // lblOneFile
            // 
            this.lblOneFile.AutoSize = true;
            this.lblOneFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOneFile.ForeColor = System.Drawing.Color.Red;
            this.lblOneFile.Location = new System.Drawing.Point(50, 223);
            this.lblOneFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOneFile.Name = "lblOneFile";
            this.lblOneFile.Size = new System.Drawing.Size(209, 18);
            this.lblOneFile.TabIndex = 14;
            this.lblOneFile.Text = "You must read at least one file!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CryptoClient.Properties.Resources.justLogoTransparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 50);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // imgExit
            // 
            this.imgExit.BackgroundImage = global::CryptoClient.Properties.Resources.XredTransparent;
            this.imgExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgExit.Location = new System.Drawing.Point(249, 10);
            this.imgExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imgExit.Name = "imgExit";
            this.imgExit.Size = new System.Drawing.Size(31, 24);
            this.imgExit.TabIndex = 8;
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
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // myLoader
            // 
            this.myLoader.Image = global::CryptoClient.Properties.Resources.loaderGray1;
            this.myLoader.InitialImage = global::CryptoClient.Properties.Resources.redLoader;
            this.myLoader.Location = new System.Drawing.Point(200, 179);
            this.myLoader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.myLoader.Name = "myLoader";
            this.myLoader.Size = new System.Drawing.Size(42, 41);
            this.myLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.myLoader.TabIndex = 5;
            this.myLoader.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(286, 325);
            this.Controls.Add(this.lblOneFile);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.myLoader);
            this.Controls.Add(this.btnXXTEA);
            this.Controls.Add(this.btnRC6);
            this.Controls.Add(this.btnAes);
            this.Controls.Add(this.lblTotalFiles);
            this.Controls.Add(this.btnChooseFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Encryptix";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLoader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.Label lblTotalFiles;
        private System.Windows.Forms.Button btnAes;
        private System.Windows.Forms.Button btnRC6;
        private System.Windows.Forms.Button btnXXTEA;
        private System.Windows.Forms.PictureBox myLoader;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblOneFile;
    }
}

