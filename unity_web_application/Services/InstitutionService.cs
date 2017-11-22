using Entities;

namespace Services
{
    public class InstitutionService : IInstitutionService
    {
        public Institution GetInstitutionByID(long institutionID)
        {
            return new Institution { InstitutionID = institutionID, Name = "Sample Institution", Address = "Sample Address", Telephone = "0123456789" };
        }
    }
}
