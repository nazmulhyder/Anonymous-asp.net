using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Anonymous_311018.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DisplayName("Number Of Student")]
        public int NumberofStudent { get; set; }
        [DisplayName("Number Of Faculty")]
        public int NumberofFaculty { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Faculty> Faculties { get; set; }
    }
}   