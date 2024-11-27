using System.Text.Json.Serialization;

namespace CoffeeReviewBackend.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //[JsonIgnore]
        public virtual ICollection<Coffee> Coffees { get; set; }
    }
}
