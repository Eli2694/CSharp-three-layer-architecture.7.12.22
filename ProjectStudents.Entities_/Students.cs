using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectStudents.DAL_;
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
            //Clear Hashtable Before Inserting Information From Sql Server
            hashTbl.Clear();
            object retHash = null;
            while(reader.Read())
            {
                Student student = new Student();
                student.Full_name = reader.GetString(reader.GetOrdinal("FullName"));
                student.Age = reader.GetInt32(reader.GetOrdinal("age"));
                student.Student_address = reader.GetString(reader.GetOrdinal("HomeAddress"));
                student.Id = reader.GetInt32(reader.GetOrdinal("StudentID"));

                //Cheking If Hashtable contains the key
                if(hashTbl.ContainsKey(student.Id))
                {
                    //key already exists
                }
                else
                {
                    //Filling a hashtable
                    hashTbl.Add(student.Id, student);
                }
                
            }

            retHash =  hashTbl;
            return retHash;
        }
        //Function that helps connect between UI and DAL and return Hashtable
        public object SendSqlQueryToReadFromDB(string SqlQuery)
        {
            
            object retHash = null;
            retHash = DAL_.SqlQuery.StartReadFromDB(SqlQuery, ReadFromDb);
            return retHash;
        }
        // Creating object of Student and inserting into hashtable
        public object AddNewStudentToHashTable(string FullName,int age,string HomeAddress,int ID)
        {
            Student newStudent = new Student() { Full_name = FullName , Age = age, Student_address = HomeAddress, Id = ID }; 
            if(hashTbl.ContainsKey(ID))
            {
                // id already exists
                return 1;
            }
            else
            {
                hashTbl.Add(newStudent.Id, newStudent);
                return newStudent;
            }
        }
        // Help insert row of student information to sql server
        public void insertIntoDB(string SqlQuery,Student StuClass)
        {
            DAL_.SqlQuery.InputToDB(SqlQuery, StuClass.Full_name, StuClass.Age, StuClass.Student_address, StuClass.Id);
        }

        // Help delete row from sql server
        public int deleteRowFromDB(string SqlQuery,int StudentID)
        {
            if(hashTbl.ContainsKey(StudentID))
            {
                hashTbl.Remove(StudentID);
                DAL_.SqlQuery.DeleteFromSqlServer(SqlQuery, StudentID);
                return 0;
            }
            else
            {
                //id was not found
                return 1;
            }
        }
        //retrive value from hashtable
        public object retriveValueFromHashT(int StudentID)
        {
            if(hashTbl.ContainsKey(StudentID))
            {
                return hashTbl[StudentID];
            }
            else
            {
                return 1;
            }
        }

        // send sql query to update row of student
        public int updateAddressInDB(string SqlQuery,string HomeAddress,int id)
        {
            int rowsAffected = DAL_.SqlQuery.UpdateRowById(SqlQuery, HomeAddress, id);
            return rowsAffected;


        }
    }
}
