namespace School2WebAPI.Entities
{
    public class AcademicArea
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // realcion a muchos course (1-m)

        public List<Course> Courses { get; } = new();

    }
}
