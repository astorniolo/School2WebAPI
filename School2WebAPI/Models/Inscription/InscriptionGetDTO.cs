using School2WebAPI.Models.Course;
using School2WebAPI.Models.Student;
using School2WebAPI.Models.Teacher;

namespace School2WebAPI.Models.Inscription
{
    public class InscriptionGetDTO
    {
        public CourseGetDTO Course { get; set; } = null!;

        public TeacherGetDTO Teacher { get; set; } = null!;

        public StudentGetDTO Student { get; set; } = null!;
    }
}
