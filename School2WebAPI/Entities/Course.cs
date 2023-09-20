
namespace School2WebAPI.Entities
{
    public class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }


        // relacion a un area academica (m-1) OPCIONAL

        public int? AcademicAreaId { get; set; }

        public AcademicArea? AcademicArea { get; set; }


        //relacion a un programConten (1-1) OBLIGATORIA

        public ProgramContent? ProgramContent { get; set; }



        // relacion a muchos teachers con tabla (m-m) c/NAVEGACION y FK

        public List<Teacher> Teachers { get; } = new();

        public List<OpenCourse> OpenCourses { get; } = new();

    }  
      
}
