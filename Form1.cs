using System;
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

namespace RSAEncryptor
{
    public partial class Form1 : Form
    {
        RSAEncryptor rsaEncryptor = new RSAEncryptor();
        private byte[] encryptedBytes = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generateKeys();
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                textBox1.Text = rsa.ToXmlString(false);
            }
        }

        private void generateKeys()
        {
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                rsaEncryptor.publicKey = rsa.ExportParameters(false);
                rsaEncryptor.privateKey = rsa.ExportParameters(true);
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text Files | *.txt";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textArea.Text = File.ReadAllText(dialog.FileName);
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text Files | *.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, textArea.Text);
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Was made by Antonkin D.O, TM-51, Variant 1");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cryptButton_Click(object sender, EventArgs e)
        {
            encryptedBytes = rsaEncryptor.Encrypt(textArea.Text);
            textArea.Text = BitConverter.ToString(encryptedBytes).Replace("-", "") + "\n";
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            byte[] decryptedText = rsaEncryptor.Decrypt(encryptedBytes);
            textArea.Text = Encoding.UTF8.GetString(decryptedText);
        }
    }
}
