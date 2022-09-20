namespace PigeonReviewProject.Models
{
    public class PigeonOwner
    {
        public int PigeonId { get; set; }
        public int OwnerId { get; set; }

        public Pigeon Pigeon { get; set; }
        public Owner Owner { get; set; }
    }
}
