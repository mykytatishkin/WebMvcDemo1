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
            // 1 - ViewBad
            // ViewBag.Students = students;

            // 2 - ViewData
            ViewData["title"] = "List of students";

            // 3 - parametrized view
            return View(students);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            List<Group> groups = new List<Group>();
            groups.Add(new Group() { Id = 1, GroupName = "G1" }) ;
            groups.Add(new Group() { Id = 2, GroupName = "G2" });
            groups.Add(new Group() { Id = 3, GroupName = "G3" });
            return View(groups);
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
