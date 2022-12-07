using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStudents.Model_
{
    public class Student
    {
        private string full_name;

        public string Full_name
        {
            get { return full_name; }
            set { full_name = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string student_address;

        public string Student_address
        {
            get { return student_address; }
            set { student_address = value; }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
