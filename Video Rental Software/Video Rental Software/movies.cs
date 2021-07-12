using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Rental_Software
{
    public partial class movies : Form
    {
        public movies()
        {
            InitializeComponent();
        }

        private void movies_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet4.movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.database1DataSet4.movies);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C: \Users\Husnain Awan\source\repos\Video Rental Software\Video Rental Software\Database1.mdf';Integrated Security=True");

            SqlCommand cmd = new SqlCommand("insert into movies values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox3.Text + "')", conn);
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
