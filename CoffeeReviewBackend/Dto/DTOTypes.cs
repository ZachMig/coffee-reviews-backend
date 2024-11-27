namespace CoffeeReviewBackend.Dto
{

    public class CoffeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BrandDto BrandDto { get; set; }
    }

    public class BrandDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    public class ReviewDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public UserDto UserDto { get; set; }
        public CoffeeDto CoffeeDto { get; set; }
    }

    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
    }

}
