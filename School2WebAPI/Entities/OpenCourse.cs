namespace School2WebAPI.Entities
{
    public class OpenCourse
    {
        //claves foraneas

        public int CourseId { get; set; }

        public int TeacherId { get; set; }

        // objetos que relaciona 

        public Course Course { get; set; } = null!;

        public Teacher Teacher { get; set; } = null!;

        //relaciones m-m de la agregacion    Student-opencourse c/tablaR Inscription    (m-m) c/NAVEGACION y FK

        public List<Student> Students { get; } = new();

        public List<Inscription> Inscriptions { get; } = new();
    }
}
