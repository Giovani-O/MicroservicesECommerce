using System.Text.Json.Serialization;

namespace MicroservicesECommerce.ProductApi.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string? Name { get; set; }

    [JsonIgnore]
    public ICollection<Product>? Products { get; set; }
}
