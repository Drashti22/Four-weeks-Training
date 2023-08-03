public class Product
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter the product name.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please enter the product price.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a valid price.")]
    public decimal Price { get; set; }
}