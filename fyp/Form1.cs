using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fyp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Foodinfo nn = new Foodinfo();
            nn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            staff nc = new staff();
            nc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            payment py = new payment();
            py.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
        }
    }
}
