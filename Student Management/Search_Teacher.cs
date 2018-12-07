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
    public partial class Search_Teacher : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=smart_school_system;Integrated Security=True");
        SqlDataAdapter d;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        public Search_Teacher()
        {
            InitializeComponent();
        }
        

        private void Search_Teacher_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            cmd = new SqlCommand("select_teacher", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@t_id", int.Parse(textBox10.Text)));

            /*SqlParameter param = new SqlParameter();
            param.Value = int.Parse(textBox10.Text);
            cmd.Parameters.Add(param);*/


            con.Open();
            cmd.ExecuteNonQuery();
            d = new SqlDataAdapter(cmd);
            d.Fill(dt);
            this.dataGridView1.DataSource = dt;
            con.Close(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          Operation_teacher insert = new Operation_teacher();
            this.Visible = false;
            insert.Show();
        }
    }
}
