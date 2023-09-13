namespace CryptoClient.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AESForm));
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
            this.myLoader = new System.Windows.Forms.PictureBox();
            this.progressDone = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.myLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAesKey
            // 
            this.lblAesKey.AutoSize = true;
            this.lblAesKey.Location = new System.Drawing.Point(35, 33);
            this.lblAesKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAesKey.Name = "lblAesKey";
            this.lblAesKey.Size = new System.Drawing.Size(121, 16);
            this.lblAesKey.TabIndex = 0;
            this.lblAesKey.Text = "Key (32 characters)";
            // 
            // lblAesIV
            // 
            this.lblAesIV.AutoSize = true;
            this.lblAesIV.Location = new System.Drawing.Point(37, 112);
            this.lblAesIV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAesIV.Name = "lblAesIV";
            this.lblAesIV.Size = new System.Drawing.Size(110, 16);
            this.lblAesIV.TabIndex = 1;
            this.lblAesIV.Text = "IV (16 characters)";
            // 
            // inputAesKey
            // 
            this.inputAesKey.Location = new System.Drawing.Point(38, 53);
            this.inputAesKey.Margin = new System.Windows.Forms.Padding(4);
            this.inputAesKey.Multiline = true;
            this.inputAesKey.Name = "inputAesKey";
            this.inputAesKey.Size = new System.Drawing.Size(299, 51);
            this.inputAesKey.TabIndex = 2;
            // 
            // inputAesIV
            // 
            this.inputAesIV.Location = new System.Drawing.Point(41, 132);
            this.inputAesIV.Margin = new System.Windows.Forms.Padding(4);
            this.inputAesIV.Name = "inputAesIV";
            this.inputAesIV.Size = new System.Drawing.Size(127, 22);
            this.inputAesIV.TabIndex = 3;
            // 
            // btnAesEnc
            // 
            this.btnAesEnc.Location = new System.Drawing.Point(68, 169);
            this.btnAesEnc.Margin = new System.Windows.Forms.Padding(4);
            this.btnAesEnc.Name = "btnAesEnc";
            this.btnAesEnc.Size = new System.Drawing.Size(100, 28);
            this.btnAesEnc.TabIndex = 4;
            this.btnAesEnc.Text = "Encrypt";
            this.btnAesEnc.UseVisualStyleBackColor = true;
            this.btnAesEnc.Click += new System.EventHandler(this.btnAesEnc_Click);
            // 
            // btnAesDec
            // 
            this.btnAesDec.Location = new System.Drawing.Point(266, 169);
            this.btnAesDec.Margin = new System.Windows.Forms.Padding(4);
            this.btnAesDec.Name = "btnAesDec";
            this.btnAesDec.Size = new System.Drawing.Size(100, 28);
            this.btnAesDec.TabIndex = 5;
            this.btnAesDec.Text = "Decrypt";
            this.btnAesDec.UseVisualStyleBackColor = true;
            this.btnAesDec.Click += new System.EventHandler(this.btnAesDec_Click);
            // 
            // lblAESTitle
            // 
            this.lblAESTitle.AutoSize = true;
            this.lblAESTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAESTitle.Location = new System.Drawing.Point(180, 9);
            this.lblAESTitle.Name = "lblAESTitle";
            this.lblAESTitle.Size = new System.Drawing.Size(63, 29);
            this.lblAESTitle.TabIndex = 6;
            this.lblAESTitle.Text = "AES";
            // 
            // cbxAESPar
            // 
            this.cbxAESPar.AutoSize = true;
            this.cbxAESPar.Location = new System.Drawing.Point(311, 132);
            this.cbxAESPar.Name = "cbxAESPar";
            this.cbxAESPar.Size = new System.Drawing.Size(113, 20);
            this.cbxAESPar.TabIndex = 7;
            this.cbxAESPar.Text = "Parallelization";
            this.cbxAESPar.UseVisualStyleBackColor = true;
            // 
            // lblEncAESDone
            // 
            this.lblEncAESDone.AutoSize = true;
            this.lblEncAESDone.Location = new System.Drawing.Point(133, 201);
            this.lblEncAESDone.Name = "lblEncAESDone";
            this.lblEncAESDone.Size = new System.Drawing.Size(145, 16);
            this.lblEncAESDone.TabIndex = 8;
            this.lblEncAESDone.Text = "Encryption complete in ";
            // 
            // lblDecAESDone
            // 
            this.lblDecAESDone.AutoSize = true;
            this.lblDecAESDone.Location = new System.Drawing.Point(133, 229);
            this.lblDecAESDone.Name = "lblDecAESDone";
            this.lblDecAESDone.Size = new System.Drawing.Size(147, 16);
            this.lblDecAESDone.TabIndex = 9;
            this.lblDecAESDone.Text = "Decryption complete in ";
            // 
            // myLoader
            // 
            this.myLoader.BackColor = System.Drawing.Color.Transparent;
            this.myLoader.Image = ((System.Drawing.Image)(resources.GetObject("myLoader.Image")));
            this.myLoader.Location = new System.Drawing.Point(193, 111);
            this.myLoader.Name = "myLoader";
            this.myLoader.Size = new System.Drawing.Size(66, 69);
            this.myLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.myLoader.TabIndex = 10;
            this.myLoader.TabStop = false;
            // 
            // progressDone
            // 
            this.progressDone.Location = new System.Drawing.Point(344, 81);
            this.progressDone.Name = "progressDone";
            this.progressDone.Size = new System.Drawing.Size(100, 23);
            this.progressDone.TabIndex = 11;
            // 
            // AESForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 254);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AESForm";
            this.Text = "AES";
            ((System.ComponentModel.ISupportInitialize)(this.myLoader)).EndInit();
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
    }
}