﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encryptor_CS_X
{
    public partial class CryptoForm : System.Windows.Forms.Form
    {
        Crypto crypto = new Crypto();
        string path = string.Empty;

        public CryptoForm()
        {
            InitializeComponent();
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            StatusConsole console = new StatusConsole(statusConsole);
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach(string filePath in filePaths)
            {
                this.path = filePath;
                Instructions.Text = filePath;
                console.add($"'{filePath}' was dragged in");
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    this.path = openFileDialog.FileName;
                }
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    this.path = fbd.SelectedPath;
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            this.crypto.Encrypt(this.path, statusConsole);
            this.path = string.Empty;
            Instructions.Text = "drag the file you want to operate on in to the form \n or use the buttons";
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            this.crypto.Decrypt(this.path);
            this.path = string.Empty;
            Instructions.Text = "drag the file you want to operate on in to the form \n or use the buttons";
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            this.crypto.GenerateKey();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CryptoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
