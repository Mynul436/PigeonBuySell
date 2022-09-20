namespace PigeonReviewProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PigeonCategory> PigeonCategories { get; set; }
    }
}
