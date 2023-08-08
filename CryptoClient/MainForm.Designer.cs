﻿namespace CryptoClient
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
            this.SuspendLayout();
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(140, 45);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(92, 43);
            this.btnChooseFolder.TabIndex = 0;
            this.btnChooseFolder.Text = "Choose folder";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // lblTotalFiles
            // 
            this.lblTotalFiles.AutoSize = true;
            this.lblTotalFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFiles.Location = new System.Drawing.Point(108, 103);
            this.lblTotalFiles.Name = "lblTotalFiles";
            this.lblTotalFiles.Size = new System.Drawing.Size(144, 20);
            this.lblTotalFiles.TabIndex = 1;
            this.lblTotalFiles.Text = "You read a total of ";
            this.lblTotalFiles.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAes
            // 
            this.btnAes.Location = new System.Drawing.Point(34, 180);
            this.btnAes.Name = "btnAes";
            this.btnAes.Size = new System.Drawing.Size(75, 23);
            this.btnAes.TabIndex = 2;
            this.btnAes.Text = "AES";
            this.btnAes.UseVisualStyleBackColor = true;
            this.btnAes.Click += new System.EventHandler(this.btnAes_Click);
            // 
            // btnRC6
            // 
            this.btnRC6.Location = new System.Drawing.Point(157, 180);
            this.btnRC6.Name = "btnRC6";
            this.btnRC6.Size = new System.Drawing.Size(75, 23);
            this.btnRC6.TabIndex = 3;
            this.btnRC6.Text = "RC6";
            this.btnRC6.UseVisualStyleBackColor = true;
            // 
            // btnXXTEA
            // 
            this.btnXXTEA.Location = new System.Drawing.Point(281, 180);
            this.btnXXTEA.Name = "btnXXTEA";
            this.btnXXTEA.Size = new System.Drawing.Size(75, 23);
            this.btnXXTEA.TabIndex = 4;
            this.btnXXTEA.Text = "XXTEA";
            this.btnXXTEA.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 247);
            this.Controls.Add(this.btnXXTEA);
            this.Controls.Add(this.btnRC6);
            this.Controls.Add(this.btnAes);
            this.Controls.Add(this.lblTotalFiles);
            this.Controls.Add(this.btnChooseFolder);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.Label lblTotalFiles;
        private System.Windows.Forms.Button btnAes;
        private System.Windows.Forms.Button btnRC6;
        private System.Windows.Forms.Button btnXXTEA;
    }
}

