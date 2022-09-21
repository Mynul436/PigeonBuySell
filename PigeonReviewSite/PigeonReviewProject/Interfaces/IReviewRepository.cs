namespace PigeonReviewProject.Interfaces
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();

        Review GetReview(int reviewId);
        ICollection<Review> GetReviewsofAPigeon(int pigeonId);

        bool ReviewExist(int reviewId);

    }
}
