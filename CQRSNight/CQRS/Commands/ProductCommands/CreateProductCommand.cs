using MediatR;

namespace CQRSNight.CQRS.Commands.ProductCommands;

public class CreateProductCommand : IRequest
{
    public string ProductName { get; set; }
    public string Description { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
}
