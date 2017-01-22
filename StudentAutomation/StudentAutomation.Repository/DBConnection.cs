using System.Data;
using System.Data.SqlClient;

namespace StudentAutomation.Repository
{
    public class DBConnection
    {
        private readonly SqlConnection sqlConnection;
        private SqlCommand sqlCommand;

        public DBConnection()
        {
            sqlConnection = new SqlConnection("Server=.;Database=StudentAutomation;Trusted_Connection=True;");
            sqlCommand = new SqlCommand();
        }

        public SqlConnection GetSqlConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {

                sqlConnection.Close();
                sqlConnection.Open();
            }
            else
            {
                sqlConnection.Open();
            }

            return sqlConnection;

        }

        public SqlCommand GetSqlCommand()
        {
            sqlCommand.Connection = GetSqlConnection();
            return sqlCommand;
        }
    }
}