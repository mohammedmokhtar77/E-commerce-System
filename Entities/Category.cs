namespace Ecommerce_System.Entities;

public class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    // Navigation Property: One Category has many Products
    public ICollection<Product> Products { get; set; }
        = new List<Product>();
}