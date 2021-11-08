using System;
using System.Net.NetworkInformation;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace ITools
{
    public partial class NIC : Form
    {
        public NIC()
        {
            InitializeComponent();

            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                textBox1.Text += "-----------------------------------------------------------------------------------\r\n";
                var ipProps = adapter.GetIPProperties();
                IPInterfaceProperties properties = adapter.GetIPProperties();
                UnicastIPAddressInformationCollection coll = properties.UnicastAddresses;


                textBox1.Text += adapter.Name + " | " + adapter.NetworkInterfaceType.ToString()
                              + "\r\n" + adapter.GetPhysicalAddress().ToString();

                foreach (UnicastIPAddressInformation inf in coll)
                    textBox1.Text += "\r\n" + inf.Address + " | " + inf.IPv4Mask;

                textBox1.Text += "\r\n\r\n DNS-Addresses:";
                foreach (IPAddress ip in properties.DnsAddresses)
                    textBox1.Text += "\r\n" + ip.ToString();

                textBox1.Text += "\r\n\r\n DHCP-Addresses:";
                foreach (IPAddress ip in properties.DhcpServerAddresses)
                    textBox1.Text += "\r\n" + ip.ToString();

                textBox1.Text += "\r\n\r\n\r\n";


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
