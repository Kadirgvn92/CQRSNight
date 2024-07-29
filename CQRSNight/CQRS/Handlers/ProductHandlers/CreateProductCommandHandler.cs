using CQRSNight.CQRS.Commands.ProductCommands;
using CQRSNight.Entity.Concrete;
using CQRSNight.Repository.GenericRepository;
using MediatR;

namespace CQRSNight.CQRS.Handlers.ProductHandlers;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
{
    private readonly IRepository<Product> _repository;

    public CreateProductCommandHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        await _repository.CreateAsync(new Product
        {
            CategoryId = request.CategoryId,    
            Description = request.Description,
            Price = request.Price,
            ProductName = request.ProductName,
            Stock = request.Stock

        });
    }
}
