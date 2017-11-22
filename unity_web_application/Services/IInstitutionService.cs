using Entities;

namespace Services
{
    public interface IInstitutionService
    {
        Institution GetInstitutionByID(long institutionID);
    }
}
