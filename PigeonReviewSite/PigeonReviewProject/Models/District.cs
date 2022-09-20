namespace PigeonReviewProject.Models
{
    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Owner> Owners { get; set; }

    }
}
