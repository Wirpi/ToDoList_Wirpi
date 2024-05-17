using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_ToDoList
{
    internal class db
    {
        public SqlConnection SqlConnection = new SqlConnection(@"Data Source=DESKTOP-ASUSZ27\SQLWIRPI;Initial Catalog=ToDoTable;Integrated Security=True");

        public void openConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return SqlConnection;
        }
    }
}
