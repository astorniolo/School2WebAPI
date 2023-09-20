namespace School2WebAPI.Entities
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        // relacion a muchos Student-Opencurse con tablaR Inscription (m-m) c/NAVEGACION y FK
        public List<OpenCourse> OpenCourses { get; } = new();

        public List<Inscription> Inscriptions { get; } = new();
    }
}
