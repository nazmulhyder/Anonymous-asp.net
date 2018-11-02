using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Anonymous_311018.DatabaseContext;
using Anonymous_311018.Models;

namespace Anonymous_311018.Controllers
{
    public class DepartmentController : Controller
    {
        StudentManagementDbContext db = new StudentManagementDbContext();
        // GET: Department
        public ActionResult Index()
        {
           return View();
        }
        public ActionResult GetDeptList()
        {
            var deptList = db.Departments.ToList<Department>();
            return Json(new { data = deptList }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(Department department)
        {
            
            db.Departments.Add(department);
            bool isSaved = db.SaveChanges() > 0;
            if (isSaved)
            {
                ViewBag.message = "successfully department added ";
            }
            return View();
        }

        public ActionResult Search()
        {
            List<Department> departments = db.Departments.ToList();
            ViewBag.department = departments;
            return View();
        }
    }
}