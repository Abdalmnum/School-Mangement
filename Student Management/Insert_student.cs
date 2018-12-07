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
    public partial class Insert_student : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=smart_school_system;Integrated Security=True");
        SqlDataAdapter d;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        public Insert_student()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert_student ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] parm = new SqlParameter[12];
            parm[0] = new SqlParameter("@id_student", SqlDbType.Int);
            parm[0].Value = int.Parse(textBox1.Text);

            parm[1] = new SqlParameter("@first_name", SqlDbType.VarChar, 10);
            parm[1].Value = textBox2.Text;

            parm[2] = new SqlParameter("@last_name", SqlDbType.VarChar, 10);
            parm[2].Value = textBox3.Text;

            parm[3] = new SqlParameter("@date_of_birth", SqlDbType.Date);
            parm[3].Value = textBox4.Text;

            parm[4] = new SqlParameter("@absence", SqlDbType.TinyInt);
            parm[4].Value = int.Parse(textBox5.Text);

            parm[5] = new SqlParameter("@phone_no", SqlDbType.VarChar, 15);
            parm[5].Value = textBox6.Text;

            parm[6] = new SqlParameter("@grade", SqlDbType.SmallInt);
            parm[6].Value = int.Parse(textBox7.Text);

            parm[7] = new SqlParameter("@level", SqlDbType.VarChar, 15);
            parm[7].Value = int.Parse(textBox8.Text);

            parm[8] = new SqlParameter("@id_school", SqlDbType.Int);
            parm[8].Value = int.Parse(textBox9.Text);

            parm[9] = new SqlParameter("@id_location", SqlDbType.Int);
            parm[9].Value = int.Parse(textBox10.Text);

            parm[10] = new SqlParameter("@id_stage", SqlDbType.Int);
            parm[10].Value = int.Parse(textBox11.Text);

            parm[11] = new SqlParameter("@id_class", SqlDbType.Int);
            parm[11].Value =int.Parse (textBox12.Text);

            cmd.Parameters.AddRange(parm);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Adding succsseded", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Operation_Student insert = new Operation_Student();
            this.Visible = false;
            insert.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
