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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void teacher_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          if (Properties.Settings.Default.password != "" && Properties.Settings.Default.username != "") { }

          if (Properties.Settings.Default.password2 != "" && Properties.Settings.Default.username2 != "") { }

          if (Properties.Settings.Default.password3 != "" && Properties.Settings.Default.username3 != "") { }
                
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Visible = false;
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Visible = false;
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Visible = false;
            form.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            courses_in_our_school form = new courses_in_our_school();
            this.Visible = false;
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           about_Project about = new about_Project();
            this.Visible = false;
            about.Show();
        } 
           
    }
}
