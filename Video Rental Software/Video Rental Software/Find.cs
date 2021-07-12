using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Rental_Software
{
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main m = new main();
            this.Hide();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.customer1TableAdapter1.Fill(this.database1DataSet9.Customer1);
            // TODO: This line of code loads data into the 'database1DataSet8.Customer1' table. You can move, or remove it, as needed.
            this.customer1TableAdapter.Fill(this.database1DataSet8.Customer1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            main m = new main();
            this.Hide();
            m.Show();
        }

        private void Find_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet9.Customer1' table. You can move, or remove it, as needed.
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.customer1TableAdapter1.FillBy(this.database1DataSet9.Customer1);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
