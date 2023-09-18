using School2WebAPI.Models.Course;
using School2WebAPI.Models.Teacher;

namespace School2WebAPI.Models.OpenCourse
{
    public class OpenCourseGetDTO
    {
            public CourseGetDTO Course { get; set; } = null!;

            public TeacherGetDTO Teacher { get; set; } = null!;
    }
}
