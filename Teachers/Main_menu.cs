using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teachers
{
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Classes m = new Manage_Classes();
            this.Hide();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Homework h = new Homework();
            this.Hide();
            h.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MarkHW m = new MarkHW();
            this.Hide();
            m.Show();
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
