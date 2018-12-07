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
    public partial class Manager_choose : Form
    {
        public Manager_choose()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operation_Student oper = new Operation_Student();
            this.Visible = false;
            oper.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operation_teacher oper = new Operation_teacher();
            this.Visible = false;
            oper.Show();
        }

        private void Manager_choose_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            courses oper = new courses();
            this.Visible = false;
            oper.Show();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
              Form1 oper = new Form1();
            this.Visible = false;
            oper.Show();
        }
    }
}
