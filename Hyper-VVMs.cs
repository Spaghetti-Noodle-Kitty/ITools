using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Management.Automation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITools
{
    public partial class Hyper_VVMs : Form
    {
        public Hyper_VVMs()
        {
            InitializeComponent();

            textBox1.Clear();
            using (PowerShell powerShell = PowerShell.Create())
            {
                powerShell.AddScript("Get-VM | Select-Object | Format-List");
                powerShell.AddCommand("Out-String");
                Collection<PSObject> PSOutput = powerShell.Invoke();
                StringBuilder stringBuilder = new StringBuilder();
                foreach (PSObject pSObject in PSOutput)
                    stringBuilder.AppendLine(pSObject.ToString());
                textBox1.Text = stringBuilder.ToString();
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
    }
}
