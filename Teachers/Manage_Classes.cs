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
    public partial class Manage_Classes : Form
    {
        public Manage_Classes()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            //enabling data view in grid view
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Desktop\Ravi_code\Teachers\user_Database.mdf;Integrated Security=True;Connect Timeout=30");
            string Query = "SELECT * From tblStd";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //enabling on clink feature of grid view
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // deleting a record
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Desktop\Ravi_code\Teachers\user_Database.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string Query1 = "Delete From tblStd where Id= '"+textBox1.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(Query1, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully");
            textBox1.Text= " ";
            textBox2.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student_Add std = new Student_Add();
            this.Hide();
            std.Show();
        }

        private void Manage_Classes_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Desktop\Ravi_code\Teachers\user_Database.mdf;Integrated Security=True;Connect Timeout=30");
            string Q = "SELECT * From tblStd";
            SqlDataAdapter sda = new SqlDataAdapter(Q, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main_menu m = new Main_menu();
            this.Hide();
            m.Show();
        }
    }
}
