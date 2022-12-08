using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStudents.DAL_
{
    public class SqlQuery
    {
        //Pointer To Function
        public delegate object SetDataReader_delegate(SqlDataReader reader);
        public static object StartReadFromDB(string SqlQuery, SetDataReader_delegate Ptrfunc)
        {
            object retHash = null;
            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string queryString = SqlQuery;

                // Adapter
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();
                    //Reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        retHash = Ptrfunc(reader);
                        return retHash;
                    }
                }
            }
        }
        public static void InputToDB(string SqlQuery,string FullName,int age,string HomeAddress,int StudentID)
        {
            
            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = SqlQuery;

                connection.Open();

                // Adapter
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    command.Parameters.AddWithValue("@FullName", FullName);
                    command.Parameters.AddWithValue("@age", age);
                    command.Parameters.AddWithValue("@HomeAddress", HomeAddress);
                    command.Parameters.AddWithValue("@StudentID", StudentID);
                    command.ExecuteNonQuery();
                    
                }
            }
        }

        public static void DeleteFromSqlServer(string SqlQuery, int StudentID)
        {

            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = SqlQuery;

                connection.Open();

                // Adapter
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    command.Parameters.AddWithValue("@StudentID", StudentID);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
