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
    public partial class Delete_Teacher : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=smart_school_system;Integrated Security=True");
        SqlCommand cmd;
        public Delete_Teacher()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Delete_Teacher_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Operation_teacher insert = new Operation_teacher();
            this.Visible = false;
            insert.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete_teacher", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parm = new SqlParameter();
            parm = new SqlParameter("@id_teacher", SqlDbType.Int);
            parm.Value = textBox1.Text;
            cmd.Parameters.Add(parm);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleting teacher is succsseded", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
