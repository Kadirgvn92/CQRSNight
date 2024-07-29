using CQRSNight.CQRS.Queries.ProductQueries;
using CQRSNight.CQRS.Results.CategoryResults;
using CQRSNight.CQRS.Results.ProductResults;
using CQRSNight.Entity.Concrete;
using CQRSNight.Repository.GenericRepository;
using MediatR;

namespace CQRSNight.CQRS.Handlers.ProductHandlers;

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
{
    private readonly IRepository<Product> _repository;

    public GetProductByIdQueryHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var product = await _repository.GetByIDAsync(request.Id);
        return new GetProductByIdQueryResult
        {
             Stock = product.Stock, 
             CategoryId = product.CategoryId,
             ProductName = product.ProductName,
             Description = product.Description,
             Price = product.Price,
             ProductId = product.ProductId  
             
        };
    }
}
