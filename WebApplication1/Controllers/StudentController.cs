using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        private static List<Student> studentList = new List<Student>() {
            new Student(){Id =1, Name="Gitika"},
            new Student(){Id =2, Name="Rajesh"},
            new Student(){Id =3, Name="Rashmi"},
        };
        public StudentController()
        {           
        }
        public ActionResult Index()
        { 
            return View(studentList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            return RedirectToAction("Index");
        }

        public ActionResult Update(int id)
        {
            var student = studentList.FirstOrDefault(s=>s.Id==id);
            return View(student);
        }

        [HttpPost]
        public ActionResult UpdateStudent(Student student)
        {
            return RedirectToAction("Index");
        }
    }
}