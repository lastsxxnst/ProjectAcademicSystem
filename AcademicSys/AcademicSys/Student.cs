﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicSys
{
    internal class Student
    {
        public static object Rows { get; internal set; }
        public int Id { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string Login { get; internal set; }
    }
}
