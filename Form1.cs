using System;
using System.Windows.Forms;

namespace ITools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hashing
            Hashing hashing = new Hashing();
            hashing.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Deletion
            Deletion deletion = new Deletion();
            deletion.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Encryption
            Encryption enc = new Encryption();
            enc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Data storage
            DataStorage ds = new DataStorage();
            ds.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Get Adapter Info
            NIC nic = new NIC();
            nic.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Get specs
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Get Open Ports
            OpenPorts op = new OpenPorts();
            op.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Get COM Ports
            OpenCOM oc = new OpenCOM();
            oc.Show();
        }
    }
}
