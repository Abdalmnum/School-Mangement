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
    public partial class courses : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=smart_school_system;Integrated Security=True");
        SqlDataAdapter d;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        public courses()
        {
            InitializeComponent();
        
            
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager_choose about = new Manager_choose();
            this.Visible = false;
            about.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert_course", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] parm= new SqlParameter[2];
            parm[0] = new SqlParameter("@name", SqlDbType.VarChar, 10);
            parm[0].Value = textBox1.Text;

            parm[1]=new SqlParameter("@id_course",SqlDbType.Int );
            parm[1].Value =int.Parse(textBox2.Text);

           

            
            cmd.Parameters.AddRange(parm);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Adding course is succsseded","Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

           cmd = new SqlCommand("delete_course", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parm = new SqlParameter();
            parm = new SqlParameter("@id_course", SqlDbType.Int);
            parm.Value = textBox2.Text;
            cmd.Parameters.Add(parm);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleting course is succsseded", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update_course", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@name", SqlDbType.VarChar,10);
            param[0].Value = textBox1.Text;
            param[1] = new SqlParameter("@id_course", SqlDbType.Int);
            param[1].Value = textBox2.Text;

            cmd.Parameters.AddRange(param);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void courses_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select_course", con);
            cmd.CommandType = CommandType.StoredProcedure;
            d = new SqlDataAdapter(cmd);
            d.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
