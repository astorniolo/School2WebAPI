namespace School2WebAPI.Entities
{
    public class ProgramContent
    {
        public int Id { get; set; }

        public string Description { get; set; }


        //relacion a un Course (1-1)  

        public int CourseId { get; set; } // clave foranea

        public Course Course { get; set; } = null!;
    }
}
