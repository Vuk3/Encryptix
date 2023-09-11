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
            this.SuspendLayout();
            // 
            // lblRC6Key
            // 
            this.lblRC6Key.AutoSize = true;
            this.lblRC6Key.Location = new System.Drawing.Point(48, 33);
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
            // RC6Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 254);
            this.Controls.Add(this.btnRC6Decrypt);
            this.Controls.Add(this.btnRC6Encrypt);
            this.Controls.Add(this.inputRC6Key);
            this.Controls.Add(this.lblRC6Key);
            this.Name = "RC6Form";
            this.Text = "RC6Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRC6Key;
        private System.Windows.Forms.TextBox inputRC6Key;
        private System.Windows.Forms.Button btnRC6Encrypt;
        private System.Windows.Forms.Button btnRC6Decrypt;
    }
}