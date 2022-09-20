namespace PigeonReviewProject.Models
{
    public class PigeonCategory
    {
        public int  PigeonId { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public Pigeon Pigeon { get; set; }
    }
}
