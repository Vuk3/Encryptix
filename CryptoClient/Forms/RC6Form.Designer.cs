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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RC6Form));
            this.lblRC6Key = new System.Windows.Forms.Label();
            this.inputRC6Key = new System.Windows.Forms.TextBox();
            this.btnRC6Encrypt = new System.Windows.Forms.Button();
            this.btnRC6Decrypt = new System.Windows.Forms.Button();
            this.lblEncRC6Done = new System.Windows.Forms.Label();
            this.lblDecRC6Done = new System.Windows.Forms.Label();
            this.cbxRC6Par = new System.Windows.Forms.CheckBox();
            this.myLoader = new System.Windows.Forms.PictureBox();
            this.lblRC6Title = new System.Windows.Forms.Label();
            this.progressDone = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.myLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRC6Key
            // 
            this.lblRC6Key.AutoSize = true;
            this.lblRC6Key.Location = new System.Drawing.Point(48, 43);
            this.lblRC6Key.Name = "lblRC6Key";
            this.lblRC6Key.Size = new System.Drawing.Size(121, 16);
            this.lblRC6Key.TabIndex = 0;
            this.lblRC6Key.Text = "Key (16 characters)";
            // 
            // inputRC6Key
            // 
            this.inputRC6Key.Location = new System.Drawing.Point(51, 71);
            this.inputRC6Key.Multiline = true;
            this.inputRC6Key.Name = "inputRC6Key";
            this.inputRC6Key.Size = new System.Drawing.Size(182, 43);
            this.inputRC6Key.TabIndex = 1;
            // 
            // btnRC6Encrypt
            // 
            this.btnRC6Encrypt.Location = new System.Drawing.Point(68, 160);
            this.btnRC6Encrypt.Name = "btnRC6Encrypt";
            this.btnRC6Encrypt.Size = new System.Drawing.Size(101, 32);
            this.btnRC6Encrypt.TabIndex = 2;
            this.btnRC6Encrypt.Text = "Encrypt";
            this.btnRC6Encrypt.UseVisualStyleBackColor = true;
            this.btnRC6Encrypt.Click += new System.EventHandler(this.btnRC6Encrypt_Click);
            // 
            // btnRC6Decrypt
            // 
            this.btnRC6Decrypt.Location = new System.Drawing.Point(255, 160);
            this.btnRC6Decrypt.Name = "btnRC6Decrypt";
            this.btnRC6Decrypt.Size = new System.Drawing.Size(106, 32);
            this.btnRC6Decrypt.TabIndex = 3;
            this.btnRC6Decrypt.Text = "Decrypt";
            this.btnRC6Decrypt.UseVisualStyleBackColor = true;
            this.btnRC6Decrypt.Click += new System.EventHandler(this.btnRC6Decrypt_Click);
            // 
            // lblEncRC6Done
            // 
            this.lblEncRC6Done.AutoSize = true;
            this.lblEncRC6Done.Location = new System.Drawing.Point(137, 195);
            this.lblEncRC6Done.Name = "lblEncRC6Done";
            this.lblEncRC6Done.Size = new System.Drawing.Size(145, 16);
            this.lblEncRC6Done.TabIndex = 9;
            this.lblEncRC6Done.Text = "Encryption complete in ";
            // 
            // lblDecRC6Done
            // 
            this.lblDecRC6Done.AutoSize = true;
            this.lblDecRC6Done.Location = new System.Drawing.Point(137, 229);
            this.lblDecRC6Done.Name = "lblDecRC6Done";
            this.lblDecRC6Done.Size = new System.Drawing.Size(147, 16);
            this.lblDecRC6Done.TabIndex = 10;
            this.lblDecRC6Done.Text = "Decryption complete in ";
            // 
            // cbxRC6Par
            // 
            this.cbxRC6Par.AutoSize = true;
            this.cbxRC6Par.Location = new System.Drawing.Point(326, 123);
            this.cbxRC6Par.Name = "cbxRC6Par";
            this.cbxRC6Par.Size = new System.Drawing.Size(113, 20);
            this.cbxRC6Par.TabIndex = 11;
            this.cbxRC6Par.Text = "Parallelization";
            this.cbxRC6Par.UseVisualStyleBackColor = true;
            // 
            // myLoader
            // 
            this.myLoader.Image = ((System.Drawing.Image)(resources.GetObject("myLoader.Image")));
            this.myLoader.Location = new System.Drawing.Point(183, 120);
            this.myLoader.Name = "myLoader";
            this.myLoader.Size = new System.Drawing.Size(66, 69);
            this.myLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.myLoader.TabIndex = 12;
            this.myLoader.TabStop = false;
            // 
            // lblRC6Title
            // 
            this.lblRC6Title.AutoSize = true;
            this.lblRC6Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRC6Title.Location = new System.Drawing.Point(199, 9);
            this.lblRC6Title.Name = "lblRC6Title";
            this.lblRC6Title.Size = new System.Drawing.Size(63, 29);
            this.lblRC6Title.TabIndex = 13;
            this.lblRC6Title.Text = "RC6";
            // 
            // progressDone
            // 
            this.progressDone.Location = new System.Drawing.Point(326, 91);
            this.progressDone.Name = "progressDone";
            this.progressDone.Size = new System.Drawing.Size(100, 23);
            this.progressDone.TabIndex = 14;
            // 
            // RC6Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 254);
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
            this.Name = "RC6Form";
            this.Text = "RC6";
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
    }
}