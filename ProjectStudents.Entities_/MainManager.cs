﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStudents.Entities_
{
    public class MainManager
    {
        //constructor
        private MainManager() { }

        // Singleton variable
        private static readonly MainManager instance = new MainManager();
        public static MainManager Instance
        {
            get { return instance; }
        }
        // Instance of Students
        // Because of it I can access to its function
        public Students students = new Students();

    }
}
