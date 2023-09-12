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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XXTEAForm));
            this.lblXXTEAKey = new System.Windows.Forms.Label();
            this.inputXXTEAKey = new System.Windows.Forms.TextBox();
            this.btnXXTEAEnc = new System.Windows.Forms.Button();
            this.btnXXTEADec = new System.Windows.Forms.Button();
            this.lblEncXXTEADone = new System.Windows.Forms.Label();
            this.lblDecXXTEADone = new System.Windows.Forms.Label();
            this.cbxXXTEAPar = new System.Windows.Forms.CheckBox();
            this.myLoader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.myLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // lblXXTEAKey
            // 
            this.lblXXTEAKey.AutoSize = true;
            this.lblXXTEAKey.Location = new System.Drawing.Point(57, 23);
            this.lblXXTEAKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXXTEAKey.Name = "lblXXTEAKey";
            this.lblXXTEAKey.Size = new System.Drawing.Size(121, 16);
            this.lblXXTEAKey.TabIndex = 0;
            this.lblXXTEAKey.Text = "Key (16 characters)";
            // 
            // inputXXTEAKey
            // 
            this.inputXXTEAKey.Location = new System.Drawing.Point(61, 60);
            this.inputXXTEAKey.Margin = new System.Windows.Forms.Padding(4);
            this.inputXXTEAKey.Multiline = true;
            this.inputXXTEAKey.Name = "inputXXTEAKey";
            this.inputXXTEAKey.Size = new System.Drawing.Size(177, 34);
            this.inputXXTEAKey.TabIndex = 1;
            // 
            // btnXXTEAEnc
            // 
            this.btnXXTEAEnc.Location = new System.Drawing.Point(61, 160);
            this.btnXXTEAEnc.Margin = new System.Windows.Forms.Padding(4);
            this.btnXXTEAEnc.Name = "btnXXTEAEnc";
            this.btnXXTEAEnc.Size = new System.Drawing.Size(100, 28);
            this.btnXXTEAEnc.TabIndex = 2;
            this.btnXXTEAEnc.Text = "Encrypt";
            this.btnXXTEAEnc.UseVisualStyleBackColor = true;
            this.btnXXTEAEnc.Click += new System.EventHandler(this.btnXXTEAEnc_Click);
            // 
            // btnXXTEADec
            // 
            this.btnXXTEADec.Location = new System.Drawing.Point(285, 160);
            this.btnXXTEADec.Margin = new System.Windows.Forms.Padding(4);
            this.btnXXTEADec.Name = "btnXXTEADec";
            this.btnXXTEADec.Size = new System.Drawing.Size(100, 28);
            this.btnXXTEADec.TabIndex = 3;
            this.btnXXTEADec.Text = "Decrypt";
            this.btnXXTEADec.UseVisualStyleBackColor = true;
            this.btnXXTEADec.Click += new System.EventHandler(this.btnXXTEADec_Click);
            // 
            // lblEncXXTEADone
            // 
            this.lblEncXXTEADone.AutoSize = true;
            this.lblEncXXTEADone.Location = new System.Drawing.Point(148, 203);
            this.lblEncXXTEADone.Name = "lblEncXXTEADone";
            this.lblEncXXTEADone.Size = new System.Drawing.Size(145, 16);
            this.lblEncXXTEADone.TabIndex = 10;
            this.lblEncXXTEADone.Text = "Encryption complete in ";
            // 
            // lblDecXXTEADone
            // 
            this.lblDecXXTEADone.AutoSize = true;
            this.lblDecXXTEADone.Location = new System.Drawing.Point(148, 229);
            this.lblDecXXTEADone.Name = "lblDecXXTEADone";
            this.lblDecXXTEADone.Size = new System.Drawing.Size(147, 16);
            this.lblDecXXTEADone.TabIndex = 11;
            this.lblDecXXTEADone.Text = "Decryption complete in ";
            // 
            // cbxXXTEAPar
            // 
            this.cbxXXTEAPar.AutoSize = true;
            this.cbxXXTEAPar.Location = new System.Drawing.Point(326, 124);
            this.cbxXXTEAPar.Name = "cbxXXTEAPar";
            this.cbxXXTEAPar.Size = new System.Drawing.Size(113, 20);
            this.cbxXXTEAPar.TabIndex = 12;
            this.cbxXXTEAPar.Text = "Parallelization";
            this.cbxXXTEAPar.UseVisualStyleBackColor = true;
            // 
            // myLoader
            // 
            this.myLoader.Image = ((System.Drawing.Image)(resources.GetObject("myLoader.Image")));
            this.myLoader.Location = new System.Drawing.Point(195, 101);
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
            this.ClientSize = new System.Drawing.Size(451, 254);
            this.Controls.Add(this.myLoader);
            this.Controls.Add(this.cbxXXTEAPar);
            this.Controls.Add(this.lblDecXXTEADone);
            this.Controls.Add(this.lblEncXXTEADone);
            this.Controls.Add(this.btnXXTEADec);
            this.Controls.Add(this.btnXXTEAEnc);
            this.Controls.Add(this.inputXXTEAKey);
            this.Controls.Add(this.lblXXTEAKey);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XXTEAForm";
            this.Text = "XXTEAForm";
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
    }
}