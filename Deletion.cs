using System;
using System.IO;
using System.Windows.Forms;

namespace ITools
{
    public partial class Deletion : Form
    {
        public Deletion()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (txbFileName.Text == "")
            { MessageBox.Show("You need to select a file"); }
            else if (!File.Exists(txbFileName.Text))
            { MessageBox.Show("File does not exist anymore"); }
            else
            {
                // Read file to be erased and create array of same size
                byte[] content = File.ReadAllBytes(txbFileName.Text);
                byte[] output = new byte[content.Length];
                // Every byte in the new array gets set to 0
                for (int i = 0; i < content.Length; i++)
                    output[i] = 0;
                // Overwrite the file contents
                File.WriteAllBytes(txbFileName.Text, output);
                // Delete file
                File.Delete(txbFileName.Text);
            }
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
    }
}
