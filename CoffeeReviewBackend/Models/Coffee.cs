using System.Text.Json.Serialization;

namespace CoffeeReviewBackend.Models
{
    public class Coffee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        [JsonIgnore]
        public virtual ICollection<Review> Reviews { get; set; }


    }
}
