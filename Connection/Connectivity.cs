using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Connection
{
    public class Connectivity
    {
        //global declaration of the variable   LAPTOP-1O8T59IS\SQLEXPRESS
        SqlConnection sqlConn;
        String connection_String = "Data Source=LAPTOP-1O8T59IS\\SQLEXPRESS;Initial Catalog=BootieStore;Integrated Security=True";
        SqlCommand sqlCmd;
        SqlDataReader sqlDatareader;

        public DataTable SelectQuery(String qry)
        {
            DataTable tbl = new DataTable();


            sqlConn = new SqlConnection(connection_String);

            sqlConn.Open();
            sqlCmd = new SqlCommand(qry, sqlConn);

            sqlDatareader = sqlCmd.ExecuteReader();

            tbl.Load(sqlDatareader);

            sqlConn.Close();

            return tbl;
        }



        //this statement is related to insert delete update query that is the main statement of any database record 
        public void record(String sqlStatement)
        {

            sqlConn = new SqlConnection(connection_String);
            sqlConn.Open();


            sqlCmd = new SqlCommand(sqlStatement, sqlConn);
            sqlCmd.ExecuteNonQuery();

            sqlConn.Close();

        }

    }
}
