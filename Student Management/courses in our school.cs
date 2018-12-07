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

namespace Student_Management
{
    public partial class courses_in_our_school : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=smart_school_system;Integrated Security=True");
        SqlDataAdapter d;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        public courses_in_our_school()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Visible = false;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select_course", con);
            cmd.CommandType = CommandType.StoredProcedure;
            d = new SqlDataAdapter(cmd);
            d.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }
    }
}
