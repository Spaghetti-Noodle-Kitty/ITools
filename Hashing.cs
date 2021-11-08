using System;
using System.IO;
using System.Windows.Forms;

namespace ITools
{
    public partial class Hashing : Form
    {
        public enum LastOperation
        {
            MD5,
            SHA256,
            Erase,
            Other
        }

        public static LastOperation operation;

        public Hashing()
        {
            InitializeComponent();
        }

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.Multiselect = false;
            ofd.Title = "Select File";
            if (ofd.ShowDialog() == DialogResult.OK)
                txbFileName.Text = ofd.FileName;
        }

        private void btnMD5hash_Click(object sender, EventArgs e)
        {
            if (txbFileName.Text == "")
            { MessageBox.Show("You need to select a file"); }
            else if (!File.Exists(txbFileName.Text))
            { MessageBox.Show("File does not exist anymore"); }
            else
            {
                operation = LastOperation.MD5;
                txbOutput.Text = HashMethods.GetMD5HashFromFile(txbFileName.Text);
            }
        }

        private void btnSHA256hash_Click(object sender, EventArgs e)
        {
            if (txbFileName.Text == "")
            { MessageBox.Show("You need to select a file"); }
            else if (!File.Exists(txbFileName.Text))
            { MessageBox.Show("File does not exist anymore"); }
            else
            {
                operation = LastOperation.SHA256;
                txbOutput.Text = HashMethods.GetSHA256HashFromFile(txbFileName.Text);
            }
        }

        private void btnCompareMD5_Click(object sender, EventArgs e)
        {
            if (txbFileName.Text == "")
            { MessageBox.Show("You need to select a file"); }
            else if (!File.Exists(txbFileName.Text))
            { MessageBox.Show("File does not exist anymore"); }
            else if (txbHash.Text == "")
            { MessageBox.Show("You need to input a Hash"); }
            else
            {
                operation = LastOperation.Other;
                if (txbHash.Text == HashMethods.GetMD5HashFromFile(txbFileName.Text))
                {
                    txbOutput.Text = "File Hash: " + HashMethods.GetMD5HashFromFile(txbFileName.Text)
                                   + "\r\nYour Hash: " + txbHash.Text
                                   + "\r\n\r\nValidated: " + "Success";
                }
                else
                {
                    txbOutput.Text = "File Hash: " + HashMethods.GetMD5HashFromFile(txbFileName.Text)
                                   + "\r\nYour Hash: " + txbHash.Text
                                   + "\r\n\r\nValidated: " + "Failure";
                }
            }
        }

        private void btnCompareSHA256_Click(object sender, EventArgs e)
        {
            operation = LastOperation.Other;
            if (txbFileName.Text == "")
            { MessageBox.Show("You need to select a file"); }
            else if (!File.Exists(txbFileName.Text))
            { MessageBox.Show("File does not exist anymore"); }
            else if (txbHash.Text == "")
            { MessageBox.Show("You need to input a Hash"); }
            else
            {
                if (txbHash.Text == HashMethods.GetSHA256HashFromFile(txbFileName.Text))
                {
                    txbOutput.Text = "File Hash: " + HashMethods.GetSHA256HashFromFile(txbFileName.Text)
                                   + "\r\nYour Hash: " + txbHash.Text
                                   + "\r\n\r\nValidated: " + "Success";
                }
                else
                {
                    txbOutput.Text = "File Hash: " + HashMethods.GetSHA256HashFromFile(txbFileName.Text)
                                   + "\r\nYour Hash: " + txbHash.Text
                                   + "\r\n\r\nValidated: " + "Failure";
                }
            }
        }

        private void btnSaveOut_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            // Determine what file extension should be used
            if (operation == LastOperation.MD5)
                sfd.Filter = "Hash Files|*.md5";
            else if (operation == LastOperation.SHA256)
                sfd.Filter = "Hash Files|*.sha256";
            else
                sfd.Filter = "Text Files|*.txt";

            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (sfd.ShowDialog() == DialogResult.OK)
                File.WriteAllText(sfd.FileName, txbOutput.Text);
        }

        private void Hashing_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
