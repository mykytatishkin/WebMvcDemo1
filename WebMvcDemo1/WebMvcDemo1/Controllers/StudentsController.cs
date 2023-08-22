using Microsoft.AspNetCore.Mvc;
using WebMvcDemo1.Models;
using WebMvcDemo1.Repositories;

namespace WebMvcDemo1.Controllers
{
    public class StudentsController : Controller
    {
        IStudents repository;

        // DI - Dependencies Injection is a way to use objects of a class inside another class
        public StudentsController(IStudents repository)
        {
            //repository = new ListStudents();    //bad practice
            this.repository = repository;
        }

        public IActionResult Index()
        {
            List<Student> students = repository.GetStudents();
            ViewBag.Students = students;
            return View();
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(int id, string name, string group, double rate)
        {
            Student student = new Student() { Id = id, Name = name, Group = group, Rate = rate};
            this.repository.AddStudent(student);

           // return View();
           return RedirectToAction("Index");
        }
    }
}


//http://localhost:5478/Students/Index
