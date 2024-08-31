using Q3DotNetAssuit.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Q3DotNetAssuit.ViewModel
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public Decimal Salary { get; set; }
        public string JobTitle { get; set; }
        public string ImageUrl { get; set; }
        public string Address { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Deparment { get; set; }
        public List<Department > DepartmentList { get; set; }
    }
}
