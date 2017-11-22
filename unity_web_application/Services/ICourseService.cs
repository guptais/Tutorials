using Entities;

namespace Services
{
    public interface ICourseService
    {
        Course GetCourseByID(long courseID);

        CourseInstitution GetCourseWithInstitution(long courseID);
    }
}
