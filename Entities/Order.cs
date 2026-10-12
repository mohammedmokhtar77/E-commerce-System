namespace Ecommerce_System.Entities;
public class Order
{
    public int Id { get; set; }

    public DateTime OrderDate { get; set; }

    // Foreign Key
    public int CustomerId { get; set; }

    // Navigation Property: Many Orders belong to one Customer
    public Customer Customer { get; set; } = null!;

    // Navigation Property: One Order has many OrderDetails
    public ICollection<OrderDetail> OrderDetails { get; set; }
        = new List<OrderDetail>();
}