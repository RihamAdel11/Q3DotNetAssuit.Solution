using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Q3DotNetAssuit.Models
{
    public class ITIContext:DbContext
    {
        public ITIContext():base()
        {
            
        }
        public DbSet<Employee > Employees { get; set; }
        public DbSet<Department > Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog = Assuit_DotNet_Q3; Integrated Security =  True; Encrypt = False; Trust Server Certificate = True");
           
        }
        
    }
}
