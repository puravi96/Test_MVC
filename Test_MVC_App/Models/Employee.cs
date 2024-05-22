﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_MVC_App.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }
        public int AddressId { get; set; }
    }
}