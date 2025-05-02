using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ttme;

public class ProductRequest
{
    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Price is required.")]
    public decimal Price { get; set; }
}