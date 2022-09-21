using PigeonReviewProject.Models;
using System.Diagnostics.Metrics;

namespace PigeonReviewProject.Interfaces
{
    public interface IDistrictRepository
    {
        ICollection<District> GetAllDistricts();
        District GetDistrictById(int id);
        District GetDistrictByOwnerId(int ownerId);
        ICollection<Owner> GetOwnersFromADistrict(int ownerId);
        bool DistrictExist(int districtId);

    }
}
