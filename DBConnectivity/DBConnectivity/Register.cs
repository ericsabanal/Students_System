using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            string lastName = txtlastname.Text.Trim();  
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
                lblMessage.Text = "Please enter your FirstName. ";
                lblMessage.ForeColor = Color.Red;
                return;
            }


            if (lastName == "")
            {
                lblMessage.Text = "Please enter your LastName. ";
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
            var result = s.AddStudent(@studentId, @firstName, @lastName, @email, @password, @gender);


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

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    foreach (DataGridViewRow rowupdate in dataGridView1.SelectedRows)
        //    {

        //        txtFirstName.Text = rowupdate.Cells[1].Value.ToString();
        //        txtLastName.Text = rowupdate.Cells[2].Value.ToString();
        //        txtEmail.Text = rowupdate.Cells[3].Value.ToString();
        //        txtPassword.Text = rowupdate.Cells[4].Value.ToString();
        //        txtGender.Text = rowupdate.Cells[5].Value.ToString();
        //        txtStudentID.Text = rowupdate.Cells[0].Value.ToString();
        //    }

        //}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            int studentId = int.Parse(txtStudentID.Text.Trim());
            string firstName = txtFirstName.Text.Trim();
            string lastName =  txtlastname.Text.Trim();
            string email =     txtEmail.Text.Trim();
            string password =  txtPassword.Text.Trim();
            string gender  =   txtGender.Text.Trim();
            


            if (txtStudentID.Text.Trim() == "")
            {
                lblMessage.Text = "Please enter your ID.";
                lblMessage.ForeColor = Color.Red;

                txtStudentID.Focus();
                return;
            }

            if (firstName == "")
            {
                lblMessage.Text = "Please enter your FirstName. ";
                lblMessage.ForeColor = Color.Red;
                return;
            }


            if (lastName == "")
            {
                lblMessage.Text = "Please enter your LastName. ";
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

            Student s = new Student();
            var result = s.Update(studentId, firstName, lastName, email, password, gender);
            if (result > 0)
            {
                lblMessage.Text = "Updated Successfully";
                lblMessage.ForeColor = Color.Green;
            }
            else
            {
                lblMessage.Text = "Failed to Registered";
                lblMessage.ForeColor = Color.Red;
            }
        }

        private void studentsShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //    Student student = new Student();
            //    dataGridView1.DataSource = student.GetAllStudents();
            stdHome home = new stdHome();
            home.Show();
        }

        private void datagridviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stdHome stdHome = new stdHome();
            stdHome.Show();

        }
    }
}

