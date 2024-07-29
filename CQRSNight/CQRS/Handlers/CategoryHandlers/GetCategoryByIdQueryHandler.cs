using CQRSNight.CQRS.Queries.CategoryQueries;
using CQRSNight.CQRS.Results.CategoryResults;
using CQRSNight.Entity.Concrete;
using CQRSNight.Repository.GenericRepository;
using MediatR;

namespace CQRSNight.CQRS.Handlers.CategoryHandlers;

public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, GetCategoryByIdQueryResult>
{
    private readonly IRepository<Category> _categoryRepository;

    public GetCategoryByIdQueryHandler(IRepository<Category> categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        var cat = await _categoryRepository.GetByIDAsync(request.Id);
        return new GetCategoryByIdQueryResult
        {
            CategoryId = cat.CategoryId,
            CategoryName = cat.CategoryName,
        };
    }
}
