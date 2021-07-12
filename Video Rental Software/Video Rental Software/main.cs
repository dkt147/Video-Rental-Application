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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome James";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cust cust = new cust();
            this.Hide();
            cust.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            movies mov = new movies();
            this.Hide();
            mov.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Borrow bo = new Borrow();
            this.Hide();
            bo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Find f = new Find();
            this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
