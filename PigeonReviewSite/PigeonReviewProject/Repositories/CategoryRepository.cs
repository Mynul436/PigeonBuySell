using AutoMapper;
using PigeonReviewProject.DBContext;
using PigeonReviewProject.Interfaces;
using PigeonReviewProject.Models;

namespace PigeonReviewProject.Repositories
{
    public class CategoryRepository : ICattegoryRepository
    {
        private readonly PigeonDBContext pigeonDBContext;
       // private readonly IMapper mapper;

        public CategoryRepository(PigeonDBContext pigeonDBContext)
        {
            this.pigeonDBContext = pigeonDBContext;
           // this.mapper = mapper;
        }
        public bool CategoryExists(int Categoryid)
        {
            //throw new NotImplementedException();

            return pigeonDBContext.Categories.Any(d=>d.Id==Categoryid);
        }

        public ICollection<Category> GetAllCategories()
        {
            return pigeonDBContext.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return pigeonDBContext.Categories.Where(d => d.Id == id).FirstOrDefault();
        }

        public ICollection<Pigeon> GetPigeosBtCategoryId(int Categoryid)
        {
            return pigeonDBContext.PigeonCategories
                .Where(d => d.CategoryId == Categoryid)
                .Select(d=>d.Pigeon).ToList();
        }
    }
}
