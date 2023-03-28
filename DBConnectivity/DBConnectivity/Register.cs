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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            lblMessage.Text = "";
            int studentId = int.Parse(txtStudentID.Text.Trim());
            string firstName = txtFirstName.Text.Trim();    
            string lastName = txtLastName.Text.Trim();  
            string email = txtEmail.Text.Trim();    
            string password = txtPassword.Text.Trim();  
            string gender = txtGender.Text.Trim();

            if (txtStudentID.Text.Trim() == "")
            {
                lblMessage.Text = "Please enter your ID.";
                lblMessage.ForeColor = Color.Red;

                txtStudentID.Focus();
                return;
            }

            if (firstName == "")
            {
                lblMessage.Text = "Please enter your name. ";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            if (email == "")
            {

                lblMessage.Text = "Please Enter your Email";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            if (!email.Contains("@"))
            {
                lblMessage.Text = "Please enter a correct email";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            //instantiate Student or Calling Student
            //var result it returns integer rows 
            Student s = new Student();
            var result = s.AddStudent(studentId, firstName, lastName, email, password, gender);
            if (result > 0)
            {
                lblMessage.Text = "Registered Successfully";
                lblMessage.ForeColor = Color.Green;
            }
            else
            {
                lblMessage.Text = "Failed to Registered";
                lblMessage.ForeColor = Color.Red;
            }

        }

    }
}

