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
    public partial class Operation_Student : Form
    {
        public Operation_Student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert_student insert = new Insert_student();
            this.Visible = false;
            insert.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update upd= new Update();
            this.Visible = false;
            upd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           search_Student about = new search_Student();
            this.Visible = false;
            about.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Delete_Student del = new Delete_Student();
            this.Visible = false;
            del.Show();
        } 

        private void Operation_Student_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Manager_choose about = new Manager_choose();
            this.Visible = false;
            about.Show();
        }
    }
}
