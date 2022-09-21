using AutoMapper;
using PigeonReviewProject.DBContext;
using PigeonReviewProject.Interfaces;

namespace PigeonReviewProject.Repositories
{
    public class DistrictRepository : IDistrictRepository
    {
        private readonly PigeonDBContext pigeonDBContext;
        private readonly IMapper mapper;

        public DistrictRepository(PigeonDBContext pigeonDBContext,IMapper mapper)
        {
            this.pigeonDBContext = pigeonDBContext;
            this.mapper = mapper;
        }
        public bool DistrictExist(int districtId)
        {
            return pigeonDBContext.Districts.Any(C => C.Id == districtId);
        }

        public ICollection<District> GetAllDistricts()
        {
            return pigeonDBContext.Districts.ToList();
        }

        public District GetDistrictById(int id)
        {
            return pigeonDBContext.Districts
                .Where(c => c.Id == id)
                .FirstOrDefault();
        }

        public District GetDistrictByOwnerId(int ownerId)
        {
            return pigeonDBContext.Owners.Where(o => o.Id == ownerId)
                .Select(s => s.District)
                .FirstOrDefault();
        }

        public ICollection<Owner> GetOwnersFromADistrict(int ownerId)
        {
            return pigeonDBContext.Owners
                 .Where(d => d.Id == ownerId).ToList();
        }
    }
}
