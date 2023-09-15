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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // lblXXTEAKey
            // 
            this.lblXXTEAKey.AutoSize = true;
            this.lblXXTEAKey.Location = new System.Drawing.Point(13, 118);
            this.lblXXTEAKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXXTEAKey.Name = "lblXXTEAKey";
            this.lblXXTEAKey.Size = new System.Drawing.Size(121, 16);
            this.lblXXTEAKey.TabIndex = 0;
            this.lblXXTEAKey.Text = "Key (16 characters)";
            // 
            // inputXXTEAKey
            // 
            this.inputXXTEAKey.Location = new System.Drawing.Point(16, 147);
            this.inputXXTEAKey.Margin = new System.Windows.Forms.Padding(4);
            this.inputXXTEAKey.Multiline = true;
            this.inputXXTEAKey.Name = "inputXXTEAKey";
            this.inputXXTEAKey.Size = new System.Drawing.Size(121, 43);
            this.inputXXTEAKey.TabIndex = 1;
            // 
            // btnXXTEAEnc
            // 
            this.btnXXTEAEnc.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnXXTEAEnc.FlatAppearance.BorderSize = 0;
            this.btnXXTEAEnc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXXTEAEnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnXXTEAEnc.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnXXTEAEnc.Location = new System.Drawing.Point(235, 131);
            this.btnXXTEAEnc.Margin = new System.Windows.Forms.Padding(4);
            this.btnXXTEAEnc.Name = "btnXXTEAEnc";
            this.btnXXTEAEnc.Size = new System.Drawing.Size(138, 40);
            this.btnXXTEAEnc.TabIndex = 2;
            this.btnXXTEAEnc.Text = "Encrypt";
            this.btnXXTEAEnc.UseVisualStyleBackColor = false;
            this.btnXXTEAEnc.Click += new System.EventHandler(this.btnXXTEAEnc_Click);
            // 
            // btnXXTEADec
            // 
            this.btnXXTEADec.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnXXTEADec.FlatAppearance.BorderSize = 0;
            this.btnXXTEADec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXXTEADec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnXXTEADec.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.btnXXTEADec.Location = new System.Drawing.Point(235, 189);
            this.btnXXTEADec.Margin = new System.Windows.Forms.Padding(4);
            this.btnXXTEADec.Name = "btnXXTEADec";
            this.btnXXTEADec.Size = new System.Drawing.Size(138, 40);
            this.btnXXTEADec.TabIndex = 3;
            this.btnXXTEADec.Text = "Decrypt";
            this.btnXXTEADec.UseVisualStyleBackColor = false;
            this.btnXXTEADec.Click += new System.EventHandler(this.btnXXTEADec_Click);
            // 
            // lblEncXXTEADone
            // 
            this.lblEncXXTEADone.AutoSize = true;
            this.lblEncXXTEADone.Location = new System.Drawing.Point(86, 246);
            this.lblEncXXTEADone.Name = "lblEncXXTEADone";
            this.lblEncXXTEADone.Size = new System.Drawing.Size(145, 16);
            this.lblEncXXTEADone.TabIndex = 10;
            this.lblEncXXTEADone.Text = "Encryption complete in ";
            // 
            // lblDecXXTEADone
            // 
            this.lblDecXXTEADone.AutoSize = true;
            this.lblDecXXTEADone.Location = new System.Drawing.Point(86, 272);
            this.lblDecXXTEADone.Name = "lblDecXXTEADone";
            this.lblDecXXTEADone.Size = new System.Drawing.Size(147, 16);
            this.lblDecXXTEADone.TabIndex = 11;
            this.lblDecXXTEADone.Text = "Decryption complete in ";
            // 
            // cbxXXTEAPar
            // 
            this.cbxXXTEAPar.AutoSize = true;
            this.cbxXXTEAPar.Location = new System.Drawing.Point(16, 206);
            this.cbxXXTEAPar.Name = "cbxXXTEAPar";
            this.cbxXXTEAPar.Size = new System.Drawing.Size(113, 20);
            this.cbxXXTEAPar.TabIndex = 12;
            this.cbxXXTEAPar.Text = "Parallelization";
            this.cbxXXTEAPar.UseVisualStyleBackColor = true;
            // 
            // lblXXTEATitle
            // 
            this.lblXXTEATitle.AutoSize = true;
            this.lblXXTEATitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXXTEATitle.Location = new System.Drawing.Point(132, 79);
            this.lblXXTEATitle.Name = "lblXXTEATitle";
            this.lblXXTEATitle.Size = new System.Drawing.Size(99, 29);
            this.lblXXTEATitle.TabIndex = 14;
            this.lblXXTEATitle.Text = "XXTEA";
            // 
            // progressDone
            // 
            this.progressDone.Location = new System.Drawing.Point(128, 206);
            this.progressDone.Name = "progressDone";
            this.progressDone.Size = new System.Drawing.Size(100, 23);
            this.progressDone.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CryptoClient.Properties.Resources.justLogoTransparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 62);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // imgExit
            // 
            this.imgExit.BackgroundImage = global::CryptoClient.Properties.Resources.XredTransparent;
            this.imgExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgExit.Location = new System.Drawing.Point(332, 11);
            this.imgExit.Name = "imgExit";
            this.imgExit.Size = new System.Drawing.Size(41, 30);
            this.imgExit.TabIndex = 21;
            this.imgExit.TabStop = false;
            this.imgExit.Click += new System.EventHandler(this.imgExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CryptoClient.Properties.Resources.justTextTransparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(90, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 62);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // myLoader
            // 
            this.myLoader.Image = global::CryptoClient.Properties.Resources.loaderGray1;
            this.myLoader.Location = new System.Drawing.Point(144, 131);
            this.myLoader.Name = "myLoader";
            this.myLoader.Size = new System.Drawing.Size(66, 69);
            this.myLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.myLoader.TabIndex = 13;
            this.myLoader.TabStop = false;
            // 
            // XXTEAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(381, 298);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XXTEAForm";
            this.Text = "XXTEA";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XXTEAForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.XXTEAForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.XXTEAForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLoader)).EndInit();
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
    }
}