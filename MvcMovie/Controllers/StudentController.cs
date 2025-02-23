
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class StudentController : Controller
    {
        //khai bao cac action tuong ung
        //Action tra ve du lieu toan bo ban ghi trong bang Student
        public IActionResult Index()
        {
            //Khai bao 1 doi tuong Student va gan gia tri
            Student std = new Student();
            std.Id = "1";
            std.FullName = "Nguyen Van A";
            return View(std);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student std)
        {
            ViewBag.Message = "ID:" + std.Id + " FullName:" + std.FullName;
            return View();
        }
    }
}
