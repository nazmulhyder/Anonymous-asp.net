using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Anonymous_311018.DatabaseContext;
using Anonymous_311018.Models;

namespace Anonymous_311018.Controllers
{
    public class StudentController : Controller
    {
        StudentManagementDbContext db = new StudentManagementDbContext();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                bool isSaved =  db.SaveChanges() > 0;
                if (isSaved)
                {
                    ViewBag.message = "Student Create Successfully";
                }
                ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Name",student.DepartmentId);
            }

            return View();
        }
    }
}