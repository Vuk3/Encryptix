using CryptoClient.Helper;
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
        public AESForm()
        {
            InitializeComponent();
            service = new ServiceClient();

        }

        public AESForm(FileExtend[] listRawFiles)
        {
            InitializeComponent();
            Initialize();

            service = new ServiceClient();
            this.listRawFiles = listRawFiles;
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
        }

        private void btnAesDec_Click(object sender, EventArgs e)
        {
            aesIVtxt = this.inputAesIV.Text;
            aesKeytxt = this.inputAesKey.Text;

            aesIVbytes = Types.StringToBytes(aesIVtxt);
            aesKeybytes = Types.StringToBytes(aesKeytxt);

            service.AesDecrypt(listRawFiles, aesKeybytes, aesIVbytes);
        }
    }
}
