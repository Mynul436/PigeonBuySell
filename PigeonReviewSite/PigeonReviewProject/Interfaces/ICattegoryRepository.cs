using PigeonReviewProject.Models;

namespace PigeonReviewProject.Interfaces
{
    public interface ICattegoryRepository
    {
        ICollection<Category> GetAllCategories();
        Category GetCategoryById(int id);

        ICollection<Pigeon> GetPigeosBtCategoryId(int Categoryid);

        bool CategoryExists(int Categoryid);



    }
}
