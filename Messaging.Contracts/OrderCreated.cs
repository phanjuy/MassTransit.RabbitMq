namespace Messaging.Contracts;

// Event message type
// https://masstransit.io/documentation/concepts/messages
public record OrderCreated
{
    public int Id { get; init; }
    public string ProductName { get; init; }
    public decimal Price { get; init; }
    public int Quantity { get; init; }

}
