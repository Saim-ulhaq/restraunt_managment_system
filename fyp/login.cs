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
using System.Data.SqlClient;

namespace fyp
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=WASEEM;Initial Catalog=rest;Integrated Security=True");
            string query = "select *FROM log_tab where username='" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Form1 f = new Form1();
                f.ShowDialog();
                


            }
            else
            {
                MessageBox.Show("invalid Username or password");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
