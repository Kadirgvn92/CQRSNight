using CQRSNight.CQRS.Results.CategoryResults;
using CQRSNight.Entity.Context;

namespace CQRSNight.CQRS.Handlers.CategoryHandlers;

public class GetCategoryQueryHandler
{
    private readonly CQRSContext _context;

    public GetCategoryQueryHandler(CQRSContext context)
    {
        _context = context;
    }
    public List<GetCategoryQueryResult> Handle()
    {
        var values = _context.Categories.Select(x => new GetCategoryQueryResult
        {
            CategoryId = x.CategoryId,
        }).ToList();
        return values;
    }
}
