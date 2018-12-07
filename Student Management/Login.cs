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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

          //  if (textBox1.Text == "manager" && textBox2.Text == "12345")
          //  {
                if (textBox1.Text == Properties.Settings.Default.username && textBox2.Text == Properties.Settings.Default.password)
                {
                    Manager_choose manager = new Manager_choose();
                    this.Visible = false;
                    manager.Show();
                }
         
        else      if (textBox1.Text == Properties.Settings.Default.username2 && textBox2.Text == Properties.Settings.Default.password2)
                {
                    teacher teacher = new teacher();
                    this.Visible = false;
                    teacher.Show();
                }
            
            else    if (textBox1.Text == Properties.Settings.Default.username3 && textBox2.Text == Properties.Settings.Default.password3)
                {
                    About_Me me = new About_Me();
                    this.Visible = false;
                    me.Show();
                }
            
            else
            { MessageBox.Show("passward or username erorr");
                }

        }
         
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
if (e.KeyCode ==Keys.Enter)
    button1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                textBox2.Focus();
        } 
    }
} 

