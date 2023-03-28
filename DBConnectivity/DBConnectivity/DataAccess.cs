using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBConnectivity
{
    public class DataAccess
    {
        //In this situation copy all except the query
        private static string dbPath = @"data source = C:\Users\csf\Desktop\database\DBConnectivity\DBConnectivity\bin\Debug\sms.db";
        public static DataTable ExecuteQuery(string query) 
        {

            //connection object
            SQLiteConnection con = new SQLiteConnection(dbPath);
            con.Open();
            //command object
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            //adapter object
            //datatable object

            //stored the data that we get from database 
            DataTable dt = new DataTable();

            //its read the data from database
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            //the method fill read the data from database
            adapter.Fill(dt);
            return dt;
        }

        //INSERT, DELETE, UPDATE
        public static int ExecuteNonQuery(string query)
        {
            //connection
            //command
            //adapter
            //datatable
            SQLiteConnection conn = new SQLiteConnection(dbPath);
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.CommandText = query;             //what command we are executing
            cmd.CommandType = CommandType.Text;  //what type of command we are executing 
            return cmd.ExecuteNonQuery();        //this returning an integer
        }
    }
}
