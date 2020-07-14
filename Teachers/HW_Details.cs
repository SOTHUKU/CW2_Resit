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
    public partial class HW_Details : Form
    {
        public HW_Details()
        {
            InitializeComponent();
        }

        private void HW_Details_Load(object sender, EventArgs e)
        {
            // show the homework details
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Desktop\Ravi_code\Teachers\user_Database.mdf;Integrated Security=True;Connect Timeout=30");
            string Q = "SELECT * From tblHW";
            SqlDataAdapter sda = new SqlDataAdapter(Q, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homework h = new Homework();
            this.Hide();
            h.Show();
        }
    }
}
