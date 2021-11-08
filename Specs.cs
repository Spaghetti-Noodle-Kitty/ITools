using System;
using System.Windows.Forms;
using System.Collections;

namespace ITools
{
    public partial class Specs : Form
    {
        private ArrayList GetInformation(string qry)
        {
            System.Management.ManagementObjectSearcher searcher;
            int i = 0;
            ArrayList arrayListInformationCollactor = new ArrayList();
            try
            {
                searcher = new System.Management.ManagementObjectSearcher("SELECT * FROM " + qry);
                foreach (System.Management.ManagementObject mo in searcher.Get())
                {
                    i++;
                    System.Management.PropertyDataCollection searcherProperties = mo.Properties;
                    foreach (System.Management.PropertyData sp in searcherProperties)
                    {
                        arrayListInformationCollactor.Add(sp);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return arrayListInformationCollactor;
        }

        public Specs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetInformation(comboBox1.Text);
        }
    }
}
