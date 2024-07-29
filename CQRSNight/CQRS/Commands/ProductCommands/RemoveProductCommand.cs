using MediatR;

namespace CQRSNight.CQRS.Commands.ProductCommands;

public class RemoveProductCommand : IRequest
{
    public int Id { get; set; }

    public RemoveProductCommand(int id)
    {
        Id = id;
    }
}
