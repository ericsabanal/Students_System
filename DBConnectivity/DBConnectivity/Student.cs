using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace DBConnectivity
{
    internal class Student
    {

            //Data Member
            //Default Private
            int studentID;
            string firstname;
            string lastName;
            string email;
            string password;
            string gender;
        internal object txtStudentID;


        //properties
        public int StudentID { get => studentID; set => studentID = value; }
            public string FirstName { get => firstname; set => firstname = value; }
            public string LastName { get => lastName; set => lastName = value; }
            public string Email { get => email; set => email = value; }
            public string Password { get => password; set => password = value; }
            public string Gender { get => gender; set => gender = value; }

            public bool LogIn(string email, string password)
            {

                string query = string.Format("SELECT * FROM Student WHERE Email = '{0}' AND Password = '{1}'", email, password);
                var dt = DataAccess.ExecuteQuery(query); //or Datatable dt = DataAccess.ExecuteQuery(query);  it means that var & Datable are the same
                  //Ang var dt ay para dito sa baba
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public DataTable GetAllStudents()
            {
                string query = "SELECT * FROM Student";
                return DataAccess.ExecuteQuery(query);
            }

            public DataTable GetStudentsByID(int id)
            {


                //connection
                //command
                //adapter
                //datatable

                string query = "SELECT * FROM Student where StudentID = " + id;
                return DataAccess.ExecuteQuery(query);
            }

            public DataTable GetStudentsByName(string name)
            {

            string query = string.Format("SELECT * FROM Student WHERE FirstName like '%{0}%'", name);
            
                return DataAccess.ExecuteQuery(query);
            
            }

            //it's return numeric or integer value that's why public int AddStudent
            public int AddStudent(
                int Id,
                string fname,
                string lname,
                string email,
                string password,
                string gender)
            {

                string query = string.Format("INSERT INTO STUDENT (StudentID,FirstName,LastName,Email,Password,Gender) " + "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", @Id, @fname, @lname, @email, @password, @gender);
                return DataAccess.ExecuteNonQuery(query);

            //(StudentID,FirstName,LastName,Email,Password,Gender) these are name in the database
        }

        public int Update(
                int Id,
                string fname,
                string lname,
                string email,
                string password,
                string gender)
            {

                string query = string.Format("UPDATE STUDENT SET FirstName = '{0}'," + "LastName = '{1}'," + "Email = '{2}'," + "Password = '{3}'," + "Gender = '{4}'," + "WHERE StudentId = '{5}'",
                  fname, lname, email, password, gender, Id);
                return DataAccess.ExecuteNonQuery(query);

            }

            public int Delete(int id)
            {
                string query = "DELETE FROM Student WHERE StudentID = " + id;
                return DataAccess.ExecuteNonQuery(query);
            }
    }
}


