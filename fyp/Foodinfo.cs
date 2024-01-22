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
    public partial class Foodinfo : Form
    {
        public Foodinfo()
        {
            InitializeComponent();
        }

        private void Food_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=WASEEM;Initial Catalog=rest;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into resttab Values(@id,@Name,@Food,@Food1,@Table)", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", (textBox2.Text));

            cnn.Parameters.AddWithValue("@Food", (textBox3.Text));

            cnn.Parameters.AddWithValue("@Food1", (textBox4.Text));

            cnn.Parameters.AddWithValue("@Table", int.Parse(textBox5.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Added");


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Foodinfo_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=WASEEM;Initial Catalog=rest;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from resttab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;




        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=WASEEM;Initial Catalog=rest;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("Update resttab set name=@Name,food=@Food,food1=@Food1,table=@Table where id=@id", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", (textBox2.Text));

            cnn.Parameters.AddWithValue("@Food", (textBox3.Text));

            cnn.Parameters.AddWithValue("@Food1", (textBox4.Text));

            cnn.Parameters.AddWithValue("@Table", int.Parse(textBox5.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated");





        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=WASEEM;Initial Catalog=rest;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("Delete resttab where id=@id", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted");


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
