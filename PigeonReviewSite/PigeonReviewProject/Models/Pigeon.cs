namespace PigeonReviewProject.Models
{
    public class Pigeon
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<PigeonCategory> PigeonCategories { get; set; }

        public ICollection<PigeonOwner> pigeonOwners { get; set; }

    }
}
