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
    public partial class Insert_Teacher : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=smart_school_system;Integrated Security=True");
        SqlDataAdapter d;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        public Insert_Teacher()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Operation_teacher insert = new Operation_teacher();
            this.Visible = false;
            insert.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("inseart_teacher", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] parm = new SqlParameter[9];

            parm[0] = new SqlParameter("@id_teacher", SqlDbType.Int);
            parm[0].Value = textBox1.Text;

            parm[1] = new SqlParameter("@first_name", SqlDbType.VarChar, 10);
            parm[1].Value = textBox2.Text;

            parm[2] = new SqlParameter("@last_name", SqlDbType.VarChar, 10);
            parm[2].Value = textBox3.Text;

            parm[3] = new SqlParameter("@date_of_birth", SqlDbType.Date);
            parm[3].Value = textBox4.Text;

            parm[4] = new SqlParameter("@job_title", SqlDbType.VarChar, 15);
            parm[4].Value = textBox5.Text;

            parm[5] = new SqlParameter("@phone_no", SqlDbType.VarChar, 15);
            parm[5].Value = textBox6.Text;

            parm[6] = new SqlParameter("@id_school", SqlDbType.Int);
            parm[6].Value = textBox7.Text;

            parm[7] = new SqlParameter("@id_location", SqlDbType.Int);
            parm[7].Value = textBox8.Text;

            parm[8] = new SqlParameter("@id_course", SqlDbType.Int);
            parm[8].Value = textBox9.Text;


            cmd.Parameters.AddRange(parm);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Adding teacher is succsseded", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
