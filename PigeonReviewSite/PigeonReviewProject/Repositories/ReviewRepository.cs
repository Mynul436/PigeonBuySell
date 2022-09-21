using AutoMapper;
using PigeonReviewProject.DBContext;
using PigeonReviewProject.Interfaces;

namespace PigeonReviewProject.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly PigeonDBContext pigeonDBContext;
        private readonly IMapper mapper;

        public ReviewRepository(PigeonDBContext pigeonDBContext,IMapper mapper)
        {
            this.pigeonDBContext = pigeonDBContext;
            this.mapper = mapper;
        }
        public Review GetReview(int reviewId)
        {
            return pigeonDBContext.Reviews
                .Where(r => r.Id == reviewId)
                .FirstOrDefault();
        }

        public ICollection<Review> GetReviews()
        {
            return pigeonDBContext.Reviews.ToList();
        }

        public ICollection<Review> GetReviewsofAPigeon(int pigeonId)
        {
            return pigeonDBContext.Reviews
                .Where(r=>r.Pigeon.Id==pigeonId)
                .ToList();
        }

        public bool ReviewExist(int reviewId)
        {
            return pigeonDBContext.Reviews.Any(r => r.Id == reviewId);  
        }
    }
}
