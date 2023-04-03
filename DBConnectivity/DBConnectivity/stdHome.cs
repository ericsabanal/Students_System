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
            dgvstudents.DataSource = student.GetAllStudents();
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
            dgvstudents.DataSource = student.GetStudentsByName(txtSearch.Text.Trim());
        }
    }
}
