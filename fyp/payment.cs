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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void payment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restDataSet.resttab4' table. You can move, or remove it, as needed.
            this.resttab4TableAdapter.Fill(this.restDataSet.resttab4);
            SqlConnection con = new SqlConnection(@"Data Source=WASEEM;Initial Catalog=rest;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from resttab3", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=WASEEM;Initial Catalog=rest;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into resttab3 Values(@id,@food,@price,@Food1,@Price1,@total)", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@food", (textBox2.Text));

            cnn.Parameters.AddWithValue("@price", (textbox3.Text));

            cnn.Parameters.AddWithValue("@Food1", (textBox4.Text));

            cnn.Parameters.AddWithValue("@Price1", int.Parse(textBox5.Text));

            cnn.Parameters.AddWithValue("@total", int.Parse(textBox5.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Added");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=WASEEM;Initial Catalog=rest;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("Delete resttab3 where id=@id", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Deleted");

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=WASEEM;Initial Catalog=rest;Integrated Security=True");


            con.Open();

            SqlCommand cnn = new SqlCommand("Update resttab3 set food=@food,price=@price,food1=@Food1,price1=@Price1,total=@total where id=@id", con);

            cnn.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@food", (textBox2.Text));

            cnn.Parameters.AddWithValue("@price", (textbox3.Text));

            cnn.Parameters.AddWithValue("@food1", (textBox4.Text));

            cnn.Parameters.AddWithValue("@price1", int.Parse(textBox5.Text));
            cnn.Parameters.AddWithValue("@total", int.Parse(textBox6.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Updated");
        }

        
       

        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
          }

        private void total_Click(object sender, EventArgs e)
        {
            textBox6.Text = textbox3.Text + textBox5.Text;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }
    }
}
