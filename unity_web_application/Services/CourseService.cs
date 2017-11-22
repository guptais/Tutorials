using Entities;

namespace Services
{
    public class CourseService : ICourseService
    {
        private IInstitutionService institutionService;

        public CourseService(IInstitutionService institutionService)
        {
            this.institutionService = institutionService;
        }

        public Course GetCourseByID(long courseID)
        {
            return new Course { CourseID = courseID, Description = "Sample course description", InstitutionID = 1, Title = "Sample Course Title" };
        }

        public CourseInstitution GetCourseWithInstitution(long courseID)
        {
            return new CourseInstitution { Course = new Course { CourseID = courseID, Description = "Sample course description", InstitutionID = 1, Title = "Sample Course Title" }, Institution = institutionService.GetInstitutionByID(1) };
        }
    }
}
