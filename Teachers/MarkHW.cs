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
    public partial class MarkHW : Form
    {
        public MarkHW()
        {
            InitializeComponent();
        }

        private void MarkHW_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Desktop\Ravi_code\Teachers\user_Database.mdf;Integrated Security=True;Connect Timeout=30");
            string Query = "SELECT * From tblMarks";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Desktop\Ravi_code\Teachers\user_Database.mdf;Integrated Security=True;Connect Timeout=30");
            string Query = "SELECT * From tblMarks";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //updating marks

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Desktop\Ravi_code\Teachers\user_Database.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string Query = " UPDATE tblMarks SET Name= '"+textBox2.Text+"',Title= '"+textBox3.Text+"',Marks= '"+textBox4.Text+"' WHERE Id= '"+textBox1.Text+"'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main_menu m = new Main_menu();
            this.Hide();
            m.Show();
        }
    }
}
