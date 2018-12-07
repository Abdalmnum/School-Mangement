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
    public partial class Update : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=smart_school_system;Integrated Security=True");
        SqlDataAdapter d;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        public Update()
        {
            InitializeComponent();
        }

        private void Update_Load(object sender, EventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Upadte_student", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] param = new SqlParameter[12];
            param[0] = new SqlParameter("@id_student", SqlDbType.Int);
            param[0].Value = textBox1.Text;
            param[1] = new SqlParameter("@first_name", SqlDbType.VarChar, 10);
            param[1].Value = textBox2.Text;
            param[2] = new SqlParameter("@last_name", SqlDbType.VarChar, 10);
            param[2].Value = textBox3.Text;
            param[3] = new SqlParameter("@date_of_birth", SqlDbType.Date);
            param[3].Value = textBox4.Text;
            param[4] = new SqlParameter("@absence", SqlDbType.TinyInt);
            param[4].Value = textBox5.Text;
            param[5] = new SqlParameter("@phone_no", SqlDbType.VarChar, 15);
            param[5].Value = textBox6.Text;
            param[6] = new SqlParameter("@grade", SqlDbType.SmallInt);
            param[6].Value = textBox7.Text;
            param[7] = new SqlParameter("@level", SqlDbType.VarChar,15);
            param[7].Value = textBox8.Text;
            
            param[8] = new SqlParameter("@id_school", SqlDbType.Int);
            param[8].Value = textBox9.Text;
            param[9] = new SqlParameter("@id_location", SqlDbType.Int);
            param[9].Value = textBox10.Text;
            param[10] = new SqlParameter("@id_stage", SqlDbType.Int);
            param[10].Value = textBox11.Text;
            param[11] = new SqlParameter("@id_class", SqlDbType.Int);
            param[11].Value = textBox12.Text;


            cmd.Parameters.AddRange(param);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            cmd = new SqlCommand("select_student", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id_student", int.Parse(textBox14.Text)));

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

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox11.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            textBox12.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            
        }
    }
}
