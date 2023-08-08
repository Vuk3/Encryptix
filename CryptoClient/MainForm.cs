﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoClient.Helper;
using CryptoServer.Helper;
using CryptoClient.ServiceReference;

namespace CryptoClient
{
    public partial class MainForm : Form
    {

        private readonly IService service;
        public MainForm()
        {
            InitializeComponent();
            service = new ServiceClient();
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            service.AesEncrypt(FilesAndFolders.FromListToArray(FilesAndFolders.ReadAllFiles(FilesAndFolders.OpenFolder())));
        }
    }
}