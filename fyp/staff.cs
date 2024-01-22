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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fyp
{
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }

        private void Food_Click(object sender, EventArgs e)
        {

        }

        private void staff_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=WASEEM;Initial Catalog=rest;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from resttab2", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=WASEEM;Initial Catalog=rest;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into resttab2 Values(@id,@Name,@Age)", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", (textBox2.Text));
            cnn.Parameters.AddWithValue("@Age", (textBox3.Text));
            

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=WASEEM;Initial Catalog=rest;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("Update resttab2 set name=@Name,Age=@Age where id=@id", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", (textBox2.Text));

            cnn.Parameters.AddWithValue("@Age", (textBox3.Text));

            

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=WASEEM;Initial Catalog=rest;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("Delete resttab2 where id=@id", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
