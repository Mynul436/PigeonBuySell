namespace PigeonReviewProject.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetAllReviewers();   
        Reviewer GetReviewerById(int id);

        ICollection<Review> GetReviewsReviewers(int reviewerId);

        bool IsReviewerExist(int reviewerId);

    }
}
