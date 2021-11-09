using System;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace ITools
{
    public partial class ENVVars : Form
    {
        public ENVVars()
        {
            InitializeComponent();
            foreach (DictionaryEntry tuple in System.Environment.GetEnvironmentVariables())
                if (tuple.Value.ToString().Contains(";"))
                {
                    textBox1.Text += tuple.Key + "\r\n";
                    foreach (string subval in tuple.Value.ToString().Split(';'))
                        textBox1.Text += " > " + subval + "\r\n";
                    textBox1.Text += "\r\n\r\n";
                }
                else
                    textBox1.Text += tuple.Key + " | " + tuple.Value + "\r\n\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files|*.txt";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (sfd.ShowDialog() == DialogResult.OK)
                File.WriteAllText(sfd.FileName, textBox1.Text);
        }
    }
}
