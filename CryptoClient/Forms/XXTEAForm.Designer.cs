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
            this.inputXXTEAKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputXXTEAKey.Multiline = true;
            this.inputXXTEAKey.Name = "inputXXTEAKey";
            this.inputXXTEAKey.Size = new System.Drawing.Size(177, 34);
            this.inputXXTEAKey.TabIndex = 1;
            // 
            // btnXXTEAEnc
            // 
            this.btnXXTEAEnc.Location = new System.Drawing.Point(61, 160);
            this.btnXXTEAEnc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnXXTEADec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXXTEADec.Name = "btnXXTEADec";
            this.btnXXTEADec.Size = new System.Drawing.Size(100, 28);
            this.btnXXTEADec.TabIndex = 3;
            this.btnXXTEADec.Text = "Decrypt";
            this.btnXXTEADec.UseVisualStyleBackColor = true;
            this.btnXXTEADec.Click += new System.EventHandler(this.btnXXTEADec_Click);
            // 
            // XXTEAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 254);
            this.Controls.Add(this.btnXXTEADec);
            this.Controls.Add(this.btnXXTEAEnc);
            this.Controls.Add(this.inputXXTEAKey);
            this.Controls.Add(this.lblXXTEAKey);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "XXTEAForm";
            this.Text = "XXTEAForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblXXTEAKey;
        private System.Windows.Forms.TextBox inputXXTEAKey;
        private System.Windows.Forms.Button btnXXTEAEnc;
        private System.Windows.Forms.Button btnXXTEADec;
    }
}