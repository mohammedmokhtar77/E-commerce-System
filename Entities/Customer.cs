namespace Ecommerce_System.Entities;

public class Customer
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    // Navigation Property: One Customer has many Orders
    public ICollection<Order> Orders { get; set; }
        = new List<Order>();
}