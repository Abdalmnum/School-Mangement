using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class Operation_teacher : Form
    {
        public Operation_teacher()
        {
            InitializeComponent();
        }

        private void Operation_teacher_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Delete_Teacher insert = new Delete_Teacher();
            this.Visible = false;
            insert.Show();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert_Teacher insert = new Insert_Teacher();
            this.Visible = false;
            insert.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Search_Teacher insert = new Search_Teacher();
            this.Visible = false;
            insert.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update_Teacher insert = new Update_Teacher();
            this.Visible = false;
            insert.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Manager_choose insert = new Manager_choose();
            this.Visible = false;
            insert.Show();
        }
    }
}
