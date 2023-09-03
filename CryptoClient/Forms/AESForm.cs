﻿using CryptoClient.Helper;
using CryptoClient.ServiceReference;
using CryptoServer.Helper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoClient.Forms;

namespace CryptoClient.Forms
{
    public partial class AESForm : Form
    {
        private readonly IService service;
        private FileExtend[] listRawFiles;
        private string aesIVtxt;
        private string aesKeytxt;

        private byte[] aesIVbytes;
        private byte[] aesKeybytes;

        private string rootFolder;
        public AESForm()
        {
            InitializeComponent();
            service = new ServiceClient();

        }

        public AESForm(FileExtend[] listRawFiles, string rootFolder)
        {
            InitializeComponent();
            Initialize();

            service = new ServiceClient();
            this.listRawFiles = listRawFiles;
            this.rootFolder = rootFolder;
        }

        private void Initialize()
        {
            this.inputAesIV.MaxLength = 16;
            this.inputAesKey.MaxLength = 32;
        }

        private void btnAesEnc_Click(object sender, EventArgs e)
        {
            aesIVtxt = this.inputAesIV.Text;
            aesKeytxt = this.inputAesKey.Text;

            aesIVbytes = Types.StringToBytes(aesIVtxt);
            aesKeybytes = Types.StringToBytes(aesKeytxt);

            service.AesEncrypt(listRawFiles, aesKeybytes, aesIVbytes);

            listRawFiles = FilesAndFolders.FromListToArray(FilesAndFolders.ReadAllFiles(rootFolder = FilesAndFolders.OpenFolder(rootFolder)));

        }

        private void btnAesDec_Click(object sender, EventArgs e)
        {
            aesIVtxt = this.inputAesIV.Text;
            aesKeytxt = this.inputAesKey.Text;

            aesIVbytes = Types.StringToBytes(aesIVtxt);
            aesKeybytes = Types.StringToBytes(aesKeytxt);

            service.AesDecrypt(listRawFiles, aesKeybytes, aesIVbytes);
            listRawFiles = FilesAndFolders.FromListToArray(FilesAndFolders.ReadAllFiles(FilesAndFolders.OpenFolder(rootFolder)));

        }
    }
}
