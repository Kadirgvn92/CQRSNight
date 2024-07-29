using CQRSNight.CQRS.Commands.CategoryCommands;
using CQRSNight.Entity.Concrete;
using CQRSNight.Entity.Context;

namespace CQRSNight.CQRS.Handlers.CategoryHandlers;

public class CreateCommandHandler
{
    private readonly CQRSContext _context;

    public CreateCommandHandler(CQRSContext context)
    {
        _context = context;
    }
    public void Handle(CreateCategoryCommand command)
    {
        _context.Categories.Add(new Category
        {
            CategoryName = command.CategoryName,
        });
        _context.SaveChanges();
    }
}
