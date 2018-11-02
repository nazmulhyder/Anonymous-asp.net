using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Anonymous_311018.Models;

namespace Anonymous_311018.DatabaseContext
{
    public class StudentManagementDbContext:DbContext
    {
        public  DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Faculty> Faculties { get; set; }

    }
}