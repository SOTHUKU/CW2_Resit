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
    public partial class Homework : Form
    {
        public Homework()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insert homework records 
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\Desktop\Ravi_code\Teachers\user_Database.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            string Query1 = "INSERT INTO tblHW (Id, Assignment, Start_date, End_date, Details) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '"+dateTimePicker1.Value.ToString()+"', '"+dateTimePicker2.Value.ToString()+"','"+richTextBox1.Text+"')";
            SqlDataAdapter sda = new SqlDataAdapter(Query1, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HW_Details hw = new HW_Details();
            this.Hide();
            hw.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main_menu m = new Main_menu();
            this.Hide();
            m.Show();
               
        }

        private void Homework_Load(object sender, EventArgs e)
        {

        }
    }
}
