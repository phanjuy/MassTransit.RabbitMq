namespace Messaging.Contracts;

// Event message type
public class OrderCreated
{
    int Id { get; set; }
    string ProductName { get; set; } = string.Empty;
    decimal Price { get; set; }
    int Quantity { get; set; }
}
