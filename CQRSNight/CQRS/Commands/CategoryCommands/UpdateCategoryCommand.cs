using MediatR;

namespace CQRSNight.CQRS.Commands.CategoryCommands;

public class UpdateCategoryCommand : IRequest
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}
