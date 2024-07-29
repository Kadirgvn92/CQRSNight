using MediatR;

namespace CQRSNight.CQRS.Commands.CategoryCommands;

public class RemoveCategoryCommand : IRequest
{
    public RemoveCategoryCommand(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}
