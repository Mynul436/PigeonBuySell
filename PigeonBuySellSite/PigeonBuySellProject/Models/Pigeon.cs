namespace PigeonReviewProject.Models
{
    public class Pigeon
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
