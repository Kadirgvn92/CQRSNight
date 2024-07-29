using CQRSNight.CQRS.Commands.ProductCommands;
using CQRSNight.Entity.Concrete;
using CQRSNight.Repository.GenericRepository;
using MediatR;

namespace CQRSNight.CQRS.Handlers.ProductHandlers;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
{
    private readonly IRepository<Product> _repository;

    public UpdateProductCommandHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIDAsync(request.ProductId);
        values.ProductName = request.ProductName;
        values.Stock = request.Stock;
        values.Price = request.Price;
        values.CategoryId = request.CategoryId;
        values.Description = request.Description;
        await _repository.UpdateAsync(values);
    }
}
