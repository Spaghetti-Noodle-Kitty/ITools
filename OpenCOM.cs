using System;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace ITools
{
    public partial class OpenCOM : Form
    {
        public OpenCOM()
        {
            InitializeComponent();
            foreach (string PortName in SerialPort.GetPortNames())
                textBox1.Text += "\r\n" + PortName;
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
