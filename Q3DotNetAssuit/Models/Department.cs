namespace Q3DotNetAssuit.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string MangerName { get; set; }
        public string Name { get; set; }
        public List<Employee>? Emps { get; set; }
    }
}
