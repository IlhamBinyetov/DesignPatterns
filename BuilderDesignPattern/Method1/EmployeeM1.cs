﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Method1
{
    public class EmployeeM1
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string UserName { get; set; }

        public string ToString()
        {
            return $"{FirstName} {LastName} {UserName}";
        }
    }
}
