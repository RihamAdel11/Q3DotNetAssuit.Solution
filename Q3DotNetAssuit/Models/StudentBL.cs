namespace Q3DotNetAssuit.Models
{
    public class StudentBL
    {
        List<Student> students;
        public StudentBL()
        {
            students = new List<Student>();
            students.Add(new Student() { Id = 1, Name = "Ahmed" ,ImageUrl="1.png"});
            students.Add(new Student() { Id = 2, Name = "Riham", ImageUrl = "1.png" });
            students.Add(new Student() { Id = 3, Name = "Nedal", ImageUrl = "2.png" });
            students.Add(new Student() { Id = 4, Name = "Hayat", ImageUrl = "2.png" });
           
        }
        public List<Student> GetAll() {
            return students;
        }
        public Student? GetById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }
    }
}
