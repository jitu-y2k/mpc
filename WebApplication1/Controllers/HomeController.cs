using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var studentViewModel = new StudentViewModel()
            {
                Student = new Student() { Id = 1, Name = "Kunal" },
                Standards = new List<Standard>()
                {
                    new Standard() {Id =1, Name= "6th" },
                    new Standard() {Id =2, Name= "7th" }
                }

            };

            //Ways to pass data to views
            //1. ViewBag
            //2. ViewData
            //3. ViewModel - Model Binding
            //4. TempData

            //ViewBag.Student = student;
            //ViewData["ApplicationName"] = student;

            //TempData["Student"] = student;

            //return RedirectToAction("Index", "Student");
            return View(studentViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //Student student = TempData["Student"] as Student;
                        
            return View("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}