using System;
using System.Windows.Forms;

namespace ITools
{
    public partial class DataStorage : Form
    {
        public DataStorage()
        {
            InitializeComponent();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (txbPass.Text == "" || txbPass.Text.Length != 16)
                MessageBox.Show("You need to set a password of 16 chars");
            else
            {
                string TMPEncTXT = txbContents.Text;
                AES.SetKey(txbPass.Text);
                txbContents.Text = AES.AesDecrypt(TMPEncTXT);
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string TMPEnc = "";

            if (txbPass.Text == "" || txbPass.Text.Length != 16)
                MessageBox.Show("You need to set a password of 16 chars");
            else
            {
                AES.SetKey(txbPass.Text);
                TMPEnc = AES.AesEncrypt(txbContents.Text);

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = DataStoreFileHandler.WorkingFolder;
                sfd.DefaultExt = ".dst";
                sfd.Filter = "Encrypted Datastore Files | *.dst";
                if (sfd.ShowDialog() == DialogResult.OK)
                    DataStoreFileHandler.WriteFileContents(sfd.FileName, TMPEnc);
                txbContents.Text = TMPEnc;
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = DataStoreFileHandler.WorkingFolder;
                ofd.DefaultExt = ".dst";
                ofd.Filter = "Encrypted Datastore Files | *.dst";
                if (ofd.ShowDialog() == DialogResult.OK)
                    txbContents.Text = DataStoreFileHandler.ReadFileContents(ofd.FileName);
        }
    }
}
