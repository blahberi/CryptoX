using System;
using System.IO;
using System.Windows.Forms;

namespace encryptor_CS_X
{
    public partial class LoadKeyForm : Form
    {
        public LoadKeyForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string keyInText = txbKey.Text;
            byte[] key = Convert.FromBase64String(keyInText);
            using (FileStream filestream = new FileStream("Key.key", FileMode.Create))
            {
                filestream.Write(key, 0, key.Length);
            }
            this.Hide();
        }

        private void txbKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string keyInText = txbKey.Text;
                byte[] key = Convert.FromBase64String(keyInText);
                using (FileStream filestream = new FileStream("Key.key", FileMode.Create))
                {
                    filestream.Write(key, 0, key.Length);
                }
                this.Hide();
            }
        }
    }
}
