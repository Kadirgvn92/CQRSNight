using CQRSNight.CQRS.Results.Product;
using MediatR;

namespace CQRSNight.CQRS.Queries.ProductQueries;

public class GetProductQuery : IRequest<List<GetProductQueryResult>>
{
}
