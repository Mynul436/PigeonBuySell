using AutoMapper;
using PigeonReviewProject.DBContext;
using PigeonReviewProject.Interfaces;

namespace PigeonReviewProject.Repositories
{
    public class ReviewerRepository : IReviewerRepository
    {
        private readonly PigeonDBContext pigeonDBContext;
        private readonly IMapper mapper;

        public ReviewerRepository(PigeonDBContext pigeonDBContext,IMapper mapper )
        {
            this.pigeonDBContext = pigeonDBContext;
            this.mapper = mapper;
        }
        public ICollection<Reviewer> GetAllReviewers()
        {
            return pigeonDBContext.Reviewers.ToList();
        }

        public Reviewer GetReviewerById(int id)
        {
            return pigeonDBContext.Reviewers
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }

        public ICollection<Review> GetReviewsReviewers(int reviewerId)
        {
            return pigeonDBContext.Reviews
                .Where(d=>d.Reviewer.Id== reviewerId).ToList();
        }

        public bool IsReviewerExist(int reviewerId)
        {
            return pigeonDBContext.Reviewers.Any(r=>r.Id== reviewerId);  
        }
    }
}
