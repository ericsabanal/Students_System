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
    public partial class stdHome : Form
    {
        public stdHome()
        {
            InitializeComponent();
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            datagridview1.DataSource = student.GetAllStudents();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSearch.Text.Trim());
            Student student = new Student();
            var result = student.Delete(id);
            if (result > 0) 
            {
                MessageBox.Show("Deleted Successfully");
            }
            else 
            {
                MessageBox.Show("Not Deleted");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //basta may value na involve maaari ilagay sa textbox
            //parameters (txtSearch.Text.Trim());
            //di siya effective
            Student student = new Student();
            datagridview1.DataSource = student.GetStudentsByName(txtSearch.Text.Trim());
        }


        private void datagridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in datagridview1.SelectedRows)
            {
               Register register = new Register();
                register.txtStudentID.Text = row.Cells[0].Value.ToString();
                register.txtFirstName.Text = row.Cells[1].Value.ToString();
                register.txtlastname.Text = row.Cells[2].Value.ToString();
                register.txtEmail.Text = row.Cells[3].Value.ToString();
                register.txtPassword.Text = row.Cells[4].Value.ToString();
                register.txtGender.Text = row.Cells[5].Value.ToString();

                register.Show();
            }
        }
    }
}
