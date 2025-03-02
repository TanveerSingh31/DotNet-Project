using Microsoft.AspNetCore.Mvc;
using first_project.Models;
using System.ComponentModel.DataAnnotations;


namespace first_project.Controllers
{
    public class StudentController : Controller
    {
        // Each function inside controller, is called - "action"

        // What is IActionResult ?
        // It is an interface that includes, different response datatypes that an “action” can return. For ex - JSON, View, string, integer, so on…

        // default route for each controller - Index
        public IActionResult Index()
        {
            return View();
        }


        // /student
        public IActionResult GetStudent()
        {
            // { Name= "Tanveer", Age=25 } -> giving this creates new record in table
            var student = new Student() { Name= "Tanveer", Age=25 };
            return View(student);
        }

        // /student
        public IActionResult GetStudentView2()
        {
            // { Name= "Tanveer", Age=25 } -> giving this creates new record in table
            var student = new Student() { Name = "Tanveer", Age = 25 };
            return View(student);
        }



        // /student
        public IActionResult GetStudentData(int id, int queryParam)
        {
            return Content("Path Param = " + id + " & " + "Query Param = " + queryParam);
        }

    }
}

