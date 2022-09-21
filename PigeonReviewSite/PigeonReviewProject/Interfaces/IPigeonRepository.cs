using PigeonReviewProject.Models;

namespace PigeonReviewProject.Interfaces
{
    public interface IPigeonRepository
    {
        ICollection<Pigeon> GetPigeons();
        Pigeon GetPigeon(int id);
        Pigeon GetPigeonByName(string name);
        decimal GetPigeonRating(int pegId);
        bool IsPigeonExist(int pegId);

    }
}
