using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Dependency;
using Q3DotNetAssuit.Models;
using Q3DotNetAssuit.ViewModel;

namespace Q3DotNetAssuit.Controllers
{
    public class EmployeeController : Controller
    {
        ITIContext context=new ITIContext();
        public IActionResult Details(int id)
        {
            string msg = "Hello From Action";
            int temp = 50;
            List<string>Branches= new List<string>();
            Branches.Add("Assuit");
            Branches.Add("Alex");
            Branches.Add("Smart Village");
            //additional Info
            ViewData["Mes"] =msg;
            ViewData["temp"] = temp;
            ViewData["Branches"] = Branches;
            ViewBag.Color = "Red";
            Employee EmpModel = context.Employees.FirstOrDefault(e=>e.Id==id);

            return View("Details",EmpModel );
        }
        public IActionResult DetailsVM(int id)
        {
           
            Employee EmpModel = context.Employees.FirstOrDefault(e => e.Id == id);
            EmpDeprtColorTempMegBrchviewModel EmpVM = new EmpDeprtColorTempMegBrchviewModel();
            EmpVM.EmpName = EmpModel.Name;
            EmpVM.DepartName = EmpModel.Deparment.Name;
            EmpVM.Color="Red";
            EmpVM.Temp = 50;
            EmpVM.Message = "Hello From ViewModel";
            List<string> Branches = new List<string>();
            Branches.Add("Assuit");
            Branches.Add("Alex");
            Branches.Add("Smart Village");
            EmpVM.Branches = Branches;

            return View("DetailsVM", EmpVM);
        }
    }
}
