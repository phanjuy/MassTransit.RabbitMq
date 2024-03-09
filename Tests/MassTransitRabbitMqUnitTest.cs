using MassTransit;
using Messaging.Contracts;
using Moq;
using Producer;
using Producer.Controllers;

namespace Tests;

public class MassTransitRabbitMqUnitTest
{
    private readonly Mock<IPublishEndpoint> _publishEndpoint;
    private readonly OrdersController _ordersController;

    public MassTransitRabbitMqUnitTest()
    {
        _publishEndpoint = new Mock<IPublishEndpoint>();
        _ordersController = new OrdersController(_publishEndpoint.Object);
    }

    [Fact]
    public async Task GivenAnOrderDto_WhenCreateOrderIsCalled_ThenEventPublishedToMassTransit()
    {
        // Arrange
        var orderDto = new OrderDto
        {
            ProductName = "Keyboard",
            Price = 99.99M,
            Quantity = 1
        };

        // Act
        await _ordersController.CreateOrder(orderDto);

        // Assert
        _publishEndpoint.Verify(p => p.Publish<OrderCreated>(It.IsAny<object>(), default), Times.Once);
    }
}