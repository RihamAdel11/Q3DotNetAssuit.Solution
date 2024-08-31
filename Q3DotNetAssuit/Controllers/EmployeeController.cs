using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Dependency;
using Q3DotNetAssuit.Models;
using Q3DotNetAssuit.ViewModel;

namespace Q3DotNetAssuit.Controllers
{
    public class EmployeeController : Controller
    {
        ITIContext context = new ITIContext();
        public IActionResult Details(int id)
        {
            string msg = "Hello From Action";
            int temp = 50;
            List<string> Branches = new List<string>();
            Branches.Add("Assuit");
            Branches.Add("Alex");
            Branches.Add("Smart Village");
            //additional Info
            ViewData["Mes"] = msg;
            ViewData["temp"] = temp;
            ViewData["Branches"] = Branches;
            ViewBag.Color = "Red";
            Employee EmpModel = context.Employees.FirstOrDefault(e => e.Id == id);

            return View("Details", EmpModel);
        }
        public IActionResult DetailsVM(int id)
        {

            Employee EmpModel = context.Employees.FirstOrDefault(e => e.Id == id);
            EmpDeprtColorTempMegBrchviewModel EmpVM = new EmpDeprtColorTempMegBrchviewModel();
            EmpVM.EmpName = EmpModel.Name;
            EmpVM.DepartName = EmpModel.Deparment.Name;
            EmpVM.Color = "Red";
            EmpVM.Temp = 50;
            EmpVM.Message = "Hello From ViewModel";
            List<string> Branches = new List<string>();
            Branches.Add("Assuit");
            Branches.Add("Alex");
            Branches.Add("Smart Village");
            EmpVM.Branches = Branches;

            return View("DetailsVM", EmpVM);
        }
        public IActionResult Index()
        {
            return View("Index", context.Employees.ToList());

        }
        public IActionResult Edit(int id)
        {
            Employee EmpModel = context.Employees.FirstOrDefault(e => e.Id == id);
            List<Department> departList = context.Departments.ToList();
            EmployeeViewModel EmployeeVM = new EmployeeViewModel();
            EmployeeVM.Name = EmpModel.Name;
            EmployeeVM.Salary = EmpModel.Salary;
            EmployeeVM.ImageUrl = EmpModel.ImageUrl;
            EmployeeVM.DepartmentId = EmpModel.DepartmentId;
            EmployeeVM.JobTitle = EmpModel.JobTitle;
            EmployeeVM.DepartmentList = departList;
            return View("Edit", EmployeeVM);

        }
        [HttpPost]
        public IActionResult SaveEdit(int id,EmployeeViewModel empReq)
        {
            if (empReq.Name is not null)
            {
                Employee EmpModel = context.Employees.FirstOrDefault(e => e.Id == id);
                EmpModel.Address = empReq.Address;
                EmpModel.Name = empReq.Name;
                EmpModel.Salary = empReq.Salary;
                EmpModel.DepartmentId = empReq.DepartmentId;
                EmpModel.JobTitle = empReq.JobTitle;
                EmpModel.ImageUrl = empReq.ImageUrl;
                context.SaveChanges();
            }
            empReq.DepartmentList = context.Departments.ToList();
            return View("Edit", empReq);

        }
    }
}
