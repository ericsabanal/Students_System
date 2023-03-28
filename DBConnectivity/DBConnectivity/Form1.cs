using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBConnectivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            Student student = new Student();
            if (student.LogIn(email,password)) 
            {
            stdHome home = new stdHome();
                home.Show();
                //if show dialog you cannot go back to your previous form
            }
            else 
            {
                lblMessage.Text = "Wrong Email or Password";
                lblMessage.ForeColor = Color.Red;
            }
        }
    }
}
