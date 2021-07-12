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
    public partial class Borrow : Form
    {
        public Borrow()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            main m = new main();
            this.Hide();
            m.Show();
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet7._return' table. You can move, or remove it, as needed.
            this.borrowTableAdapter.Fill(this.database1DataSet6.borrow);
            // TODO: This line of code loads data into the 'database1DataSet6.borrow' table. You can move, or remove it, as needed.


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.returnTableAdapter.Fill(this.database1DataSet7._return);

        }
    }
}
