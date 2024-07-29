using CQRSNight.CQRS.Commands.ProductCommands;
using CQRSNight.Entity.Concrete;
using CQRSNight.Repository.GenericRepository;
using MediatR;

namespace CQRSNight.CQRS.Handlers.ProductHandlers;

public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommand>
{
    private readonly IRepository<Product> _repository;

    public RemoveProductCommandHandler(IRepository<Product> repository)
    {
        _repository = repository;
    }

    public async Task Handle(RemoveProductCommand request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetByIDAsync(request.Id);
        await _repository.DeleteAsync(values);
    }
}
