
using System;
using System.IO;
using System.Windows.Forms;

namespace encryptor_CS_X
{
    public partial class CryptoForm : Form
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
            foreach (string filePath in filePaths)
            {
                this.path = filePath;
                btnEncrypt.Enabled = true;
                btnDecrypt.Enabled = true;
                lblFileName.Text = Path.GetFileName(this.path);
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
                    btnEncrypt.Enabled = true;
                    btnDecrypt.Enabled = true;
                    lblFileName.Text = Path.GetFileName(this.path);
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
                    btnEncrypt.Enabled = true;
                    btnDecrypt.Enabled = true;
                    lblFileName.Text = Path.GetFileName(this.path);
                }
            }
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            this.crypto.Encrypt(this.path, statusConsole);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            this.crypto.Decrypt(this.path, statusConsole);
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            this.crypto.GenerateKey(statusConsole);
        }
        private void btnSaveKey_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Key file|*.key";
            save.Title = "Save Key";
            save.ShowDialog();
            if (save.FileName != "")
            {
                byte[] key = GetKey();
                using (FileStream filestream = new FileStream(save.FileName, FileMode.Create))
                {
                    filestream.Write(key, 0, key.Length);
                }
            }
        }

        private void btnLoadKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog();
            load.Filter = "Key file|*.key";
            load.Title = "Load Key";
            load.ShowDialog();
            if (load.FileName != "")
            {
                byte[] key = new byte[48];
                using (FileStream filestream = new FileStream(load.FileName, FileMode.Open))
                {
                    filestream.Read(key, 0, key.Length);
                }
                using (FileStream filestream = new FileStream("Key.key", FileMode.Create))
                {
                    filestream.Write(key, 0, key.Length);
                }
            }
        }

        private void btnCopyKey_Click(object sender, EventArgs e)
        {
            string keyInText;
            byte[] key = GetKey();
            keyInText = Convert.ToBase64String(key, 0, key.Length, Base64FormattingOptions.None);
            Clipboard.SetText(keyInText);
        }
        
        private byte[] GetKey()
        {
            byte[] key = new byte[48];
            using (FileStream filestream = new FileStream("Key.key", FileMode.Open))
            {
                filestream.Read(key, 0, key.Length);
            }
            return key;
        }

        private void btnSaveKeyAsText_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text file|*.txt";
            save.Title = "Save Key";
            save.ShowDialog();
            if (save.FileName != "")
            {
                byte[] key = GetKey();
                using (FileStream filestream = new FileStream(save.FileName, FileMode.Create))
                {
                    string keyAsText = Convert.ToBase64String(key, 0, key.Length, Base64FormattingOptions.None);
                    using (StreamWriter streamwriter = new StreamWriter(filestream))
                    {
                        streamwriter.Write(keyAsText, 0, key.Length);
                    }
                }
            }
        }

        private void btnLoadKeyFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog();
            load.Filter = "Text file|*.txt";
            load.Title = "Load Key";
            load.ShowDialog();
            if (load.FileName != "")
            {
                string keyInText;
                using (FileStream filestream = new FileStream(load.FileName, FileMode.Open))
                {
                    using (StreamReader streamreader = new StreamReader(filestream))
                    {
                        keyInText = streamreader.ReadLine();
                    }
                }
                byte[] key = Convert.FromBase64String(keyInText);
                using (FileStream filestream = new FileStream("Key.key", FileMode.Create))
                {
                    filestream.Write(key, 0, key.Length);
                }
            }
        }

        private void btnLoadKeyFromText_Click(object sender, EventArgs e)
        {
            LoadKeyForm load = new LoadKeyForm();
            load.Show();
        }

    }
}