using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HPlusSport.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int Sku { get; set; }
        public string Description { get; set; } = String.Empty;
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [JsonIgnore]
        public virtual Category? Category { get; set; }
    }
}
