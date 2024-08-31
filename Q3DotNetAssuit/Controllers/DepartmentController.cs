using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Q3DotNetAssuit.Models;

namespace Q3DotNetAssuit.Controllers
{
    public class DepartmentController : Controller
    {ITIContext context=new ITIContext ();
        [HttpGet]
        public IActionResult Index()
        {
            List<Department > list = context.Departments.Include(d=>d.Emps) .ToList ();
            return View("Index",list);
        }
        public IActionResult Add()
         {
          
            return View("Add");
        }
        [HttpPost]
        public IActionResult SaveAdd(Department departObj)
        {
            if(departObj is not null)
            {
                context.Departments.Add(departObj);
                context.SaveChanges ();
                return RedirectToAction("Index");
            }
            return View("Add", departObj);
        }
    }
}
