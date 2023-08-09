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
            this.lblAesKey = new System.Windows.Forms.Label();
            this.lblAesIV = new System.Windows.Forms.Label();
            this.inputAesKey = new System.Windows.Forms.TextBox();
            this.inputAesIV = new System.Windows.Forms.TextBox();
            this.btnAesEnc = new System.Windows.Forms.Button();
            this.btnAesDec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAesKey
            // 
            this.lblAesKey.AutoSize = true;
            this.lblAesKey.Location = new System.Drawing.Point(26, 27);
            this.lblAesKey.Name = "lblAesKey";
            this.lblAesKey.Size = new System.Drawing.Size(99, 13);
            this.lblAesKey.TabIndex = 0;
            this.lblAesKey.Text = "Key (64 characters)";
            // 
            // lblAesIV
            // 
            this.lblAesIV.AutoSize = true;
            this.lblAesIV.Location = new System.Drawing.Point(26, 99);
            this.lblAesIV.Name = "lblAesIV";
            this.lblAesIV.Size = new System.Drawing.Size(91, 13);
            this.lblAesIV.TabIndex = 1;
            this.lblAesIV.Text = "IV (16 characters)";
            // 
            // inputAesKey
            // 
            this.inputAesKey.Location = new System.Drawing.Point(29, 45);
            this.inputAesKey.Multiline = true;
            this.inputAesKey.Name = "inputAesKey";
            this.inputAesKey.Size = new System.Drawing.Size(225, 42);
            this.inputAesKey.TabIndex = 2;
            // 
            // inputAesIV
            // 
            this.inputAesIV.Location = new System.Drawing.Point(29, 115);
            this.inputAesIV.Name = "inputAesIV";
            this.inputAesIV.Size = new System.Drawing.Size(96, 20);
            this.inputAesIV.TabIndex = 3;
            // 
            // btnAesEnc
            // 
            this.btnAesEnc.Location = new System.Drawing.Point(50, 155);
            this.btnAesEnc.Name = "btnAesEnc";
            this.btnAesEnc.Size = new System.Drawing.Size(75, 23);
            this.btnAesEnc.TabIndex = 4;
            this.btnAesEnc.Text = "Encrypt";
            this.btnAesEnc.UseVisualStyleBackColor = true;
            this.btnAesEnc.Click += new System.EventHandler(this.btnAesEnc_Click);
            // 
            // btnAesDec
            // 
            this.btnAesDec.Location = new System.Drawing.Point(179, 155);
            this.btnAesDec.Name = "btnAesDec";
            this.btnAesDec.Size = new System.Drawing.Size(75, 23);
            this.btnAesDec.TabIndex = 5;
            this.btnAesDec.Text = "Decrypt";
            this.btnAesDec.UseVisualStyleBackColor = true;
            this.btnAesDec.Click += new System.EventHandler(this.btnAesDec_Click);
            // 
            // AESForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 206);
            this.Controls.Add(this.btnAesDec);
            this.Controls.Add(this.btnAesEnc);
            this.Controls.Add(this.inputAesIV);
            this.Controls.Add(this.inputAesKey);
            this.Controls.Add(this.lblAesIV);
            this.Controls.Add(this.lblAesKey);
            this.Name = "AESForm";
            this.Text = "AES";
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
    }
}