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
using System.Data.Sql;
using System.Data.OleDb;

namespace Teachers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sqlconnection for user login
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Desktop\Ravi_code\Teachers\user_Database.mdf;Integrated Security=True;Connect Timeout=30");
            string Query = "SELECT * From Login WHERE username= '" + textBox1.Text.Trim() + "' AND password= '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count == 1 )
            {
                Main_menu m = new Main_menu();
                this.Hide();
                m.Show();
            }
            else
            {
                MessageBox.Show("Username or Password is Incorect");
            }
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
