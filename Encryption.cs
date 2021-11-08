using System;
using System.Windows.Forms;

namespace ITools
{
    public partial class Encryption : Form
    {
        public Encryption()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TMPEnc = "";

            if (txbPass.Text == "" || txbPass.Text.Length != 16)
                MessageBox.Show("You need to set a password of 16 chars");
            else
            {
                try
                {
                    AES.SetKey(txbPass.Text);
                    TMPEnc = AES.AesEncrypt(txbIN.Text);

                    txbOut.Text = TMPEnc;
                }
                catch { }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbPass.Text == "" || txbPass.Text.Length != 16)
                    MessageBox.Show("You need to set a password of 16 chars");
                else
                {
                    string TMPEncTXT = txbIN.Text;
                    AES.SetKey(txbPass.Text);
                    txbOut.Text = AES.AesDecrypt(TMPEncTXT);
                }
            }
            catch
            { MessageBox.Show("Cannot decrypt Input"); }
        }
    }
}
