using System;
using System.IO;
using System.Windows.Forms;

namespace ITools
{
    public partial class OpenPorts : Form
    {
        public OpenPorts()
        {
            InitializeComponent();
            foreach (Ports.Port p in Ports.GetNetStatPorts())
            {
                textBox1.Text += "\r\n[" + p.port_number + "/" + p.protocol + "] | " + p.process_name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files|*.txt";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (sfd.ShowDialog() == DialogResult.OK)
                File.WriteAllText(sfd.FileName, textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
