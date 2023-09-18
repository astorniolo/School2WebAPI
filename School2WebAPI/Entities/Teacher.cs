namespace School2WebAPI.Entities
{
    public class Teacher
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        // relacion con muchos Course por tabla opencourse

        public List<Course> Courses { get; } = new();

        public List<OpenCourse> OpenCourses { get; } = new();
    }
}
