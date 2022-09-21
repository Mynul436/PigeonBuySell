using PigeonReviewProject.DBContext;
using PigeonReviewProject.Interfaces;
using PigeonReviewProject.Models;

namespace PigeonReviewProject.Repositories
{
    public class PigeonRepository:IPigeonRepository
    {
        private readonly PigeonDBContext _dBContext;

        public PigeonRepository(PigeonDBContext dBContext)
        {
            this._dBContext = dBContext;
        }

        public Pigeon GetPigeon(int id)
        {
            // throw new NotImplementedException();

            return _dBContext.Pigeon.Where(p => p.Id == id).FirstOrDefault();
        }

        public Pigeon GetPigeonByName(string name)
        {
            return _dBContext.Pigeon.Where(p => p.Name == name).FirstOrDefault();
        }

        public decimal GetPigeonRating(int pegId)
        {
            var review=_dBContext.Reviews.Where(p => p.Id == pegId);
            if (review.Count() <= 0)
            {
                return 0;
            }
            return ((decimal)review.Sum(r=>r.Rating)/review.Count());
        }

        public ICollection<Pigeon> GetPigeons()
        {
            return _dBContext.Pigeon.OrderBy(p=>p.Id).ToList();
        }

        public bool IsPigeonExist(int pegId)
        {
            return _dBContext.Pigeon.Any(p => p.Id == pegId);
        }
    }
}
