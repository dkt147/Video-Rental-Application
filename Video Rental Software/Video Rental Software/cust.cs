using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Video_Rental_Software
{

    public partial class cust : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C: \Users\Husnain Awan\source\repos\Video Rental Software\Video Rental Software\Database1.mdf';Integrated Security=True");


        public cust()
        {
            InitializeComponent();
        }

        private void cust_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet3.Customer1' table. You can move, or remove it, as needed.
            this.customer1TableAdapter.Fill(this.database1DataSet3.Customer1);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            main m = new main();
            this.Hide();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into customer1 values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox3.Text + "')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added Successfully");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            conn.Close();
        }
    }
}
