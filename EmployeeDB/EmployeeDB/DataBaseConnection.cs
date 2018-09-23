using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EmployeeDB
{
    class DataBaseConnection
    {
        //Make the instance of class
        private static DataBaseConnection Instance;

        //initialize the sql connection
        private SqlConnection connection;

        //Initialize a string
        public string ConnectionString;

        /// <summary>
        /// Private Constructor
        /// </summary>
        private DataBaseConnection()
        {

        }

        /// <summary>
        /// Create the object of class
        /// </summary>
        /// <returns>return instance of object</returns>
        public static DataBaseConnection getInstance()
        {
            if(Instance == null) {
                Instance = new DataBaseConnection();
            }
            return Instance;
        }

        /// <summary>
        /// It open the Connection to the database if connection is closed
        /// </summary>
        /// <returns>return that connection</returns>
        public SqlConnection getConnection()
        {
            connection = new SqlConnection(ConnectionString);
            if(connection.State != ConnectionState.Open)
                connection.Open();
            return connection;
        }

        /// <summary>
        /// This function read the data from database
        /// </summary>
        /// <param name="commandText">This is query you give to read or do other things with database</param>
        /// <returns>return sqldatareader object</returns>
        public SqlDataReader getData(string commandText)
        {
            connection = getConnection();
            SqlCommand sqlcmd = new SqlCommand(commandText, connection);
            SqlDataReader reader = sqlcmd.ExecuteReader();
            return reader;
        } 

        /// <summary>
        /// this function add the data to the datatable from database
        /// </summary>
        /// <param name="DBName">it Takes the Database Name</param>
        /// <returns></returns>
        public DataTable ShowData(string DBName)
        {
            string query = "Select * from " + DBName;
            SqlDataAdapter sql = new SqlDataAdapter(query, DataBaseConnection.getInstance().getConnection());
            DataTable table = new DataTable();
            sql.Fill(table);
            table.Columns.Remove("Id");
            return table;
        }

        /// <summary>
        /// this function execute the query to add the data to database.
        /// </summary>
        /// <param name="commandText">This is query you give to read or do other things with database</param>
        /// <returns>return number of rows affected</returns>
        public int executeQuery(string commandText)
        {
            connection = getConnection();
            SqlCommand sqlcmd = new SqlCommand(commandText, connection);
            int rows = sqlcmd.ExecuteNonQuery();
            return rows;
        }

        /// <summary>
        /// This function check that the given text already present in database or not.
        /// </summary>
        /// <param name="text">The text you want to check</param>
        /// <param name="DBName">Database name</param>
        /// <param name="check">the element present in database</param>
        /// <returns></returns>
        public int alreadyPresentInDB(string text, string DBName, string check)
        {
            string query = "Select count(" + check +") as " + check + " from " + DBName + " where " + check + " = '" + text + "' ";
            SqlCommand cmd = new SqlCommand(query, getConnection());
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            return result;
        }

        /// <summary>
        /// This count the rows of datatable in database
        /// </summary>
        /// <param name="DBName">Database Name</param>
        /// <returns></returns>
        public int CountRows(string DBName)
        {
            int count = 0;
            SqlCommand cmd = new SqlCommand("Select * from " + DBName, getConnection());
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                count += 1;
            }
            return count;
        }

        public int CountColumns(string DBName)
        {
            int count;
            SqlDataAdapter sql = new SqlDataAdapter("Select * from " + DBName, getConnection());
            DataTable table = new DataTable();
            sql.Fill(table);
            count = table.Columns.Count;
            return count;
        }

        /// <summary>
        /// This function close the connection when called
        /// </summary>
        public void closeConnection()
        {
            if(connection != null)
                connection.Close();
        }
    }
}
