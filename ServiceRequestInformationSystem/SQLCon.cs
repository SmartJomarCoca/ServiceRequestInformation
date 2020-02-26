using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ServiceRequestInformationSystem
{
    static class SQLCon
    {
        public static DataSet dataSet = new DataSet();
        public static SqlCommand sqlCommand;
        public static SqlDataReader sqlDataReader;
        public static SqlDataAdapter sqlDataApater = new SqlDataAdapter();
        public static SqlConnection sqlConnection = new SqlConnection();
        public static DataTable dataTable = new DataTable();
        public static string sql;

        static string dataSource = "PpYCha-PC";
        static string databaseName = "SrisDb";

        public static void DbCon()
        {
            try
            {
                sqlConnection.Close();
                sqlConnection = new SqlConnection("Data Source='" + dataSource + "'; Initial Catalog='" + databaseName + "'; Integrated Security=true");
                sqlConnection.Open();


            }
            catch (Exception)
            {
                MessageBox.Show("System can not stablish a connection to database!");
            }
        }
    }
}