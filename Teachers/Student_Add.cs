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

namespace Teachers
{
    public partial class Student_Add : Form
    {
        public Student_Add()
        {
            InitializeComponent();
        }

        private void Student_Add_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Desktop\Ravi_code\Teachers\user_Database.mdf;Integrated Security=True;Connect Timeout=30");
            string Query = "SELECT * From tblReq";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Desktop\Ravi_code\Teachers\user_Database.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string Query1 = "INSERT INTO tblStd (Id, name) VALUES ('"+textBox1.Text+"', '"+textBox2.Text+"')";
            SqlDataAdapter sda = new SqlDataAdapter(Query1, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
            con.Open();
            string Query2 = "Delete From tblReq where Id= '" + textBox1.Text + "'";
            SqlDataAdapter sda1 = new SqlDataAdapter(Query2, con);
            sda1.SelectCommand.ExecuteNonQuery();
            con.Close();
            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_Classes m = new Manage_Classes();
            this.Hide();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Desktop\Ravi_code\Teachers\user_Database.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string Query = "Delete From tblReq where Id= '" + textBox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully");
            textBox1.Text = " ";
            textBox2.Text = " ";
        }
    }
}
