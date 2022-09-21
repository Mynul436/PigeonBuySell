using AutoMapper;
using PigeonReviewProject.DBContext;
using PigeonReviewProject.Interfaces;
using PigeonReviewProject.Models;

namespace PigeonReviewProject.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly PigeonDBContext pigeonDBContext;
        private readonly IMapper mapper;

        public OwnerRepository(PigeonDBContext pigeonDBContext,IMapper mapper)
        {
            this.pigeonDBContext = pigeonDBContext;
            this.mapper = mapper;
        }
        public ICollection<Owner> GetAllOwner()
        {
            return pigeonDBContext.Owners.ToList();
        }

        public Owner GetOwner(int ownerId)
        {
            return pigeonDBContext.Owners
                .Where(o => o.Id == ownerId)
                .FirstOrDefault();

        }

        public ICollection<Owner> GetOwnerOfAPigeon(int pigeonId)
        {
            return pigeonDBContext.PigeonOwners
                .Where(p => p.Pigeon.Id == pigeonId)
                .Select(o => o.Owner)
                .ToList();
        }

        public ICollection<Pigeon> GetPigeonOfAOwner(int ownerId)
        {
            return pigeonDBContext.PigeonOwners
                  .Where(p => p.Owner.Id == ownerId)
                  .Select(o => o.Pigeon)
                  .ToList();
        }

        public bool OwnerExists(int ownerId)
        {
            return pigeonDBContext.Owners.Any(o=>o.Id==ownerId);
        }
    }
}
