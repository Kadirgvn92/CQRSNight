using CQRSNight.CQRS.Commands.CategoryCommands;
using CQRSNight.Entity.Concrete;
using CQRSNight.Entity.Context;
using CQRSNight.Repository.GenericRepository;
using MediatR;

namespace CQRSNight.CQRS.Handlers.CategoryHandlers;

public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand>
{
    private readonly IRepository<Category> _categoryRepository;

    public UpdateCategoryCommandHandler(IRepository<Category> categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        var values = await _categoryRepository.GetByIDAsync(request.CategoryId);
        values.CategoryName = request.CategoryName;
        await _categoryRepository.UpdateAsync(values);
    }
}
