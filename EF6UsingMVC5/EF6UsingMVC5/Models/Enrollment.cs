namespace EF6UsingMVC5.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        #region Properties

        //Primary Key
        public int EnrollmentID { get; set; }
        
        //Foreign Keys
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        #endregion

        #region Navigational Properties

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; } 
        
        #endregion
    }
}