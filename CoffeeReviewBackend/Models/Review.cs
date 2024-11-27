namespace CoffeeReviewBackend.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int CoffeeId { get; set; }
        public virtual Coffee Coffee { get; set; }

    }
}
