using System;
using System.IO;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Drawing;

namespace ITools
{
    public partial class Services : Form
    {
        public Services()
        {
            DateTime dt = DateTime.Now;

            InitializeComponent();

            foreach (ServiceController sc in ServiceController.GetServices())
            {
                richTextBox1.SelectionStart = richTextBox1.TextLength;
                richTextBox1.SelectionLength = 0;


                if (sc.Status == ServiceControllerStatus.Running)
                    richTextBox1.SelectionColor = Color.LightGreen;
                if (sc.Status == ServiceControllerStatus.Stopped)
                    richTextBox1.SelectionColor = Color.Red;
                if (sc.Status == ServiceControllerStatus.Paused)
                    richTextBox1.SelectionColor = Color.Yellow;

                richTextBox1.AppendText(dt + " | " + sc.DisplayName + " (" + sc.ServiceName + ") | " + sc.Status.ToString() + "\r\n");
                richTextBox1.SelectionColor = richTextBox1.ForeColor;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files|*.txt";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (sfd.ShowDialog() == DialogResult.OK)
                File.WriteAllText(sfd.FileName, richTextBox1.Text);
        }
    }
}
