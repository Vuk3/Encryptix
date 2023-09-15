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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRC6Key
            // 
            this.lblRC6Key.AutoSize = true;
            this.lblRC6Key.Location = new System.Drawing.Point(12, 110);
            this.lblRC6Key.Name = "lblRC6Key";
            this.lblRC6Key.Size = new System.Drawing.Size(121, 16);
            this.lblRC6Key.TabIndex = 0;
            this.lblRC6Key.Text = "Key (16 characters)";
            // 
            // inputRC6Key
            // 
            this.inputRC6Key.Location = new System.Drawing.Point(12, 129);
            this.inputRC6Key.Multiline = true;
            this.inputRC6Key.Name = "inputRC6Key";
            this.inputRC6Key.Size = new System.Drawing.Size(121, 43);
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
            this.btnRC6Encrypt.Location = new System.Drawing.Point(236, 120);
            this.btnRC6Encrypt.Name = "btnRC6Encrypt";
            this.btnRC6Encrypt.Size = new System.Drawing.Size(138, 40);
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
            this.btnRC6Decrypt.Location = new System.Drawing.Point(236, 188);
            this.btnRC6Decrypt.Name = "btnRC6Decrypt";
            this.btnRC6Decrypt.Size = new System.Drawing.Size(138, 40);
            this.btnRC6Decrypt.TabIndex = 3;
            this.btnRC6Decrypt.Text = "Decrypt";
            this.btnRC6Decrypt.UseVisualStyleBackColor = false;
            this.btnRC6Decrypt.Click += new System.EventHandler(this.btnRC6Decrypt_Click);
            // 
            // lblEncRC6Done
            // 
            this.lblEncRC6Done.AutoSize = true;
            this.lblEncRC6Done.Location = new System.Drawing.Point(84, 242);
            this.lblEncRC6Done.Name = "lblEncRC6Done";
            this.lblEncRC6Done.Size = new System.Drawing.Size(145, 16);
            this.lblEncRC6Done.TabIndex = 9;
            this.lblEncRC6Done.Text = "Encryption complete in ";
            // 
            // lblDecRC6Done
            // 
            this.lblDecRC6Done.AutoSize = true;
            this.lblDecRC6Done.Location = new System.Drawing.Point(84, 262);
            this.lblDecRC6Done.Name = "lblDecRC6Done";
            this.lblDecRC6Done.Size = new System.Drawing.Size(147, 16);
            this.lblDecRC6Done.TabIndex = 10;
            this.lblDecRC6Done.Text = "Decryption complete in ";
            // 
            // cbxRC6Par
            // 
            this.cbxRC6Par.AutoSize = true;
            this.cbxRC6Par.Location = new System.Drawing.Point(15, 188);
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
            this.lblRC6Title.Location = new System.Drawing.Point(142, 76);
            this.lblRC6Title.Name = "lblRC6Title";
            this.lblRC6Title.Size = new System.Drawing.Size(73, 32);
            this.lblRC6Title.TabIndex = 13;
            this.lblRC6Title.Text = "RC6";
            // 
            // progressDone
            // 
            this.progressDone.Location = new System.Drawing.Point(131, 205);
            this.progressDone.Name = "progressDone";
            this.progressDone.Size = new System.Drawing.Size(100, 23);
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
            this.myLoader.Location = new System.Drawing.Point(148, 120);
            this.myLoader.Name = "myLoader";
            this.myLoader.Size = new System.Drawing.Size(66, 69);
            this.myLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.myLoader.TabIndex = 12;
            this.myLoader.TabStop = false;
            // 
            // RC6Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(379, 295);
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
    }
}