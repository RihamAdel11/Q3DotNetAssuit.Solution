using Microsoft.AspNetCore.Mvc;
using Q3DotNetAssuit.Models;

namespace Q3DotNetAssuit.Controllers
{
    public class StudentController : Controller
    {
        //Student/ShowAll
        public IActionResult ShowAll()
        {
            StudentBL studentBL = new StudentBL();
            List<Student> studentList = studentBL .GetAll ();
            return View("ShowAll", studentList);
        }
        public IActionResult Details(int id)
        {
            StudentBL studentBL = new StudentBL();
            Student student = studentBL.GetById(id);
            return View("ShowDetails",student);

        }
    }
}
