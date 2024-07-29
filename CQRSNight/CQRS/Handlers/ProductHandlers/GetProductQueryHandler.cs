using CQRSNight.CQRS.Queries.ProductQueries;
using CQRSNight.CQRS.Results.CategoryResults;
using CQRSNight.CQRS.Results.Product;
using CQRSNight.Entity.Concrete;
using CQRSNight.Repository.GenericRepository;
using MediatR;

namespace CQRSNight.CQRS.Handlers.ProductHandlers;

public class GetProductQueryHandler : IRequestHandler<GetProductQuery, List<GetProductQueryResult>>
{
    private readonly IRepository<Product> _repository;

    public GetProductQueryHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetProductQueryResult>> Handle(GetProductQuery request, CancellationToken cancellationToken)
    {
        var products = await _repository.GetAllAsync();

        return products.Select(c => new GetProductQueryResult
        {
            CategoryId = c.CategoryId,
            ProductId = c.ProductId,
            ProductName = c.ProductName,
            Description = c.Description,
            Price = c.Price,
            Stock = c.Stock 
        }).ToList();
    }
}
