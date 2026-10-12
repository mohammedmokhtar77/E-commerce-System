namespace Ecommerce_System.Entities;

// Composite Primary + Foreign Key (OrderId , ProductId) 
public class OrderDetail
{
    public int OrderId { get; set; }
    
    public int ProductId { get; set; }

    public int Quantity { get; set; }

    // Navigation Property
    public Order Order { get; set; } = null!;

    // Navigation Property
    public Product Product { get; set; } = null!;
}