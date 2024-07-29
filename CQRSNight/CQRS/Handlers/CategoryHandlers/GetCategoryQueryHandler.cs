using CQRSNight.CQRS.Queries.CategoryQueries;
using CQRSNight.CQRS.Results.CategoryResults;
using CQRSNight.Entity.Concrete;
using CQRSNight.Entity.Context;
using CQRSNight.Repository.GenericRepository;
using MediatR;

namespace CQRSNight.CQRS.Handlers.CategoryHandlers;

public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, List<GetCategoryQueryResult>>
{
    private readonly IRepository<Category> _repository;

    public GetCategoryQueryHandler(IRepository<Category> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetCategoryQueryResult>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
    {
        var categories = await _repository.GetAllAsync();

        return categories.Select(c => new GetCategoryQueryResult
        {
            CategoryId = c.CategoryId,
            CategoryName = c.CategoryName,
        }).ToList();
    }
}
