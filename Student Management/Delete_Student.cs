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

    public partial class Delete_Student : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=smart_school_system;Integrated Security=True");
        SqlDataAdapter d;
        SqlCommand cmd;
        DataTable dt = new DataTable();
        public Delete_Student()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete_student", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter parm = new SqlParameter();
            parm = new SqlParameter("@id_student", SqlDbType.Int);
            parm.Value = textBox1.Text;
            cmd.Parameters.Add(parm);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleting student is succsseded", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
