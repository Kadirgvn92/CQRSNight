using CQRSNight.CQRS.Commands.CategoryCommands;
using CQRSNight.Entity.Concrete;
using CQRSNight.Entity.Context;
using CQRSNight.Repository.GenericRepository;
using MediatR;

namespace CQRSNight.CQRS.Handlers.CategoryHandlers;

public class RemoveCategoryCommandHandler : IRequestHandler<RemoveCategoryCommand>  
{
    private readonly IRepository<Category> _categoryRepository;

    public RemoveCategoryCommandHandler(IRepository<Category> categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task Handle(RemoveCategoryCommand request, CancellationToken cancellationToken)
    {
        var values = await _categoryRepository.GetByIDAsync(request.Id);
        await _categoryRepository.DeleteAsync(values);
    }
}
