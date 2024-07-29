using CQRSNight.CQRS.Commands.CategoryCommands;
using CQRSNight.Entity.Context;

namespace CQRSNight.CQRS.Handlers.CategoryHandlers;

public class RemoveCategoryCommandHandler
{
    private readonly CQRSContext _context;

    public RemoveCategoryCommandHandler(CQRSContext context)
    {
        _context = context;
    }
    public void Handle(RemoveCategoryCommand command)
    {
        var values = _context.Categories.Find(command.CategoryId);
        if (values != null)
        {
            _context.Categories.Remove(values);
            _context.SaveChanges();
        }
    }
}
