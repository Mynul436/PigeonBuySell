namespace PigeonReviewProject.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gym { get; set; }

        public District District { get; set; }

        public ICollection<PigeonOwner> PigeonOwners { get; set; }
    }
}
