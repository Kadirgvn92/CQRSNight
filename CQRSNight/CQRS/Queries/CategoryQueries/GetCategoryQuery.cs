using CQRSNight.CQRS.Results.CategoryResults;
using MediatR;

namespace CQRSNight.CQRS.Queries.CategoryQueries;

public class GetCategoryQuery : IRequest<List<GetCategoryQueryResult>>
{
}
