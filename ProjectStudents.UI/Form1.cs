using System;
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
            hashtable =  MainManager.Instance.students.SendSqlQueryToReadFromDB("select* from Students;");
            ret = (Hashtable)hashtable;
            
        }
    }
}
