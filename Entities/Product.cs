namespace Ecommerce_System.Entities;

public class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }

    // Foreign Key
    public int CategoryId { get; set; }

    // Navigation Property: Many Products belong to one Category
    public Category Category { get; set; } = null!;

    // Navigation Property: A Product can appear in many OrderDetails
    public ICollection<OrderDetail> OrderDetails { get; set; }
        = new List<OrderDetail>();
}