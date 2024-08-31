using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Q3DotNetAssuit.Models;

namespace Q3DotNetAssuit.Controllers
{
    public class DepartmentController : Controller
    {ITIContext context=new ITIContext ();
        public IActionResult Index()
        {
            List<Department > list = context.Departments.Include(d=>d.Emps) .ToList ();
            return View("Index",list);
        }
    }
}
