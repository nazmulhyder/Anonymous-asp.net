using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Anonymous_311018.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegNo { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}