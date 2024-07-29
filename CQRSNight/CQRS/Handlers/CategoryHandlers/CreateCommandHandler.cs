using CQRSNight.CQRS.Commands.CategoryCommands;
using CQRSNight.Entity.Concrete;
using CQRSNight.Entity.Context;
using CQRSNight.Repository.GenericRepository;
using MediatR;

namespace CQRSNight.CQRS.Handlers.CategoryHandlers;

public class CreateCommandHandler : IRequestHandler<CreateCategoryCommand>
{
    private readonly IRepository<Category> _categoryRepository;

    public CreateCommandHandler(IRepository<Category> categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
        await _categoryRepository.CreateAsync(new Category
        {
            CategoryName = request.CategoryName,
        });
    }
}
