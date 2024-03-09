using MassTransit;
using Messaging.Contracts;
using System.Text.Json;

namespace Consumer;

internal class OrderCreatedConsumer : IConsumer<OrderCreated>
{
    public Task Consume(ConsumeContext<OrderCreated> context)
    {
        var jsonMessage = JsonSerializer.Serialize(context.Message);
        Console.WriteLine($"OrderCreated message: {jsonMessage}");
        return Task.CompletedTask;
    }
}