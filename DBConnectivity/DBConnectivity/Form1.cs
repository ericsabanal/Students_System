using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Common;

namespace DBConnectivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connection object
            SQLiteConnection con = new SQLiteConnection(@"data source = C:\Users\csf\Desktop\database\DBConnectivity\DBConnectivity\bin\Debug\sms.db");
            con.Open();
            //command object
            string query = "SELECT * FROM Student";
            SQLiteCommand cmd = new SQLiteCommand(query,con);
            //adapter object
            //datatable object

            //stored the data that we get from database 
            DataTable dt = new DataTable();

            //its read the data from database
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            //the method fill read the data from database
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
           
        }
    }
}
