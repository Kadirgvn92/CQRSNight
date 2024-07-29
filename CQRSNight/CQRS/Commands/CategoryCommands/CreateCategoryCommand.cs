using MediatR;

namespace CQRSNight.CQRS.Commands.CategoryCommands;

public class CreateCategoryCommand : IRequest
{
    public string CategoryName { get; set; }
}
