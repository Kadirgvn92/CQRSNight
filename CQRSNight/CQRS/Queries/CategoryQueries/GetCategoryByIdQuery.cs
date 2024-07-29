using CQRSNight.CQRS.Results.CategoryResults;
using MediatR;

namespace CQRSNight.CQRS.Queries.CategoryQueries;

public class GetCategoryByIdQuery : IRequest<GetCategoryByIdQueryResult>
{
    public int Id { get; set; }

    public GetCategoryByIdQuery(int id)
    {
        Id = id;
    }
}
