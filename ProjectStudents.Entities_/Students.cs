using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectStudents.Model_;

namespace ProjectStudents.Entities_
{
    public class Students
    {
        //Global Hashtable
        public Hashtable hashTbl = new Hashtable();

        // get data from sql server and insert it into hashtable
        public object ReadFromDb(SqlDataReader reader)
        {
            object retHash = null;
            while(reader.Read())
            {
                Student student = new Student();
                student.Full_name = reader.GetString(reader.GetOrdinal("FullName"));
                student.Age = reader.GetInt32(reader.GetOrdinal("age"));
                student.Student_address = reader.GetString(reader.GetOrdinal("HomeAddress"));
                student.Id = reader.GetInt32(reader.GetOrdinal("StudentID"));

                //Filling a hashtable
                hashTbl.Add(student.Id, student);
            }

            retHash =  hashTbl;
            return retHash;
        }
        //Function that helps connect between UI and DAL
        public object SendSqlQueryToReadFromDB(string SqlQuery)
        {
            object retHash = null;
            retHash = DAL_.SqlQuery.StartReadFromDB(SqlQuery, ReadFromDb);
            return retHash;
        }
    }
}
