namespace School2WebAPI.Entities
{
    public class Inscription
    {
        public int CourseId { get; set; }

        public int TeacherId { get; set; }

        public int StudentId { get; set; }


        // m-m con tabla
        public Student Student { get; set; } = null!;

        public OpenCourse OpenCourse { get; set; } = null!;
    }
}
