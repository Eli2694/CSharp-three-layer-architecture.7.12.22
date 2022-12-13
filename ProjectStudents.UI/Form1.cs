﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectStudents.Entities_;
using ProjectStudents.Model_;

namespace ProjectStudents.UI
{
    public partial class Form1 : Form
    {
        //Global Variables
        object hashtable;
        Hashtable ret;
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            // Clear the items from the list box
            listBox1.Items.Clear();

            hashtable =  MainManager.Instance.students.SendSqlQueryToReadFromDB("select* from Students;");
            ret = (Hashtable)hashtable;

            foreach(Student value in ret.Values)
            {
                listBox1.Items.Add("Full Name: "+ value.Full_name+ " " + "Id: "+ value.Id.ToString()  + " " + "Age: " + value.Age.ToString() + " " + "Home Address: " + value.Student_address);
            }
            
        }

        private void Input_Click(object sender, EventArgs e)
        {
            object insertHashTable = MainManager.Instance.students.AddNewStudentToHashTable(t_fullName.Text, int.Parse(t_age.Text), t_address.Text, int.Parse(t_id.Text));
            if(insertHashTable is Student)
            {
                
                MessageBox.Show("Inserting Into Sql Server");
                MainManager.Instance.students.insertIntoDB("insert into Students(FullName,age,HomeAddress,StudentID)values(@FullName,@age,@HomeAddress,@StudentID);", (Student)insertHashTable);
            }
            else
            {
                MessageBox.Show("Id already exists in hashtable");

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int ret = MainManager.Instance.students.deleteRowFromDB("delete from Students where StudentID = @StudentID;", int.Parse(t_id.Text));
            if(ret == 1)
            {
                MessageBox.Show("StudentID Was Not Found In HashTable");
            }
            else
            {
                MessageBox.Show("key = " + " " + t_id.Text + " " + " was removed from Hashtable" );
            }
        }

        private void Retrieval_Click(object sender, EventArgs e)
        {
            object s1 = MainManager.Instance.students.retriveValueFromHashT(int.Parse(t_id.Text));
            if(s1 is Student)
            {
                Student student = (Student)s1;
                t_fullName.Text = student.Full_name;
                t_age.Text = student.Age.ToString();
                t_address.Text = student.Student_address;
            }
            else
            {
                MessageBox.Show("StudentID Was Not Found In HashTable");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowsAffected = MainManager.Instance.students.updateAddressInDB("update students set HomeAddress = @HomeAddress where StudentID = @StudentID", t_address.Text, int.Parse(t_id.Text));
            if(rowsAffected == 1)
            {
                MessageBox.Show(rowsAffected + "row is affected");
            }
            else if(rowsAffected > 1)
            {
                MessageBox.Show(rowsAffected + "rows are affected");
            }
            else
            {
                MessageBox.Show(rowsAffected + "rows are affected");
            }
        }
    }
}
