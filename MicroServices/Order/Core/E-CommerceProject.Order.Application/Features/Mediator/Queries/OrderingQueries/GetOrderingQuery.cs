using E_CommerceProject.Order.Application.Features.Mediator.Results.OrderingResults;
using MediatR;

namespace E_CommerceProject.Order.Application.Features.Mediator.Queries.OrderingQueries
{
    public class GetOrderingQuery : IRequest<List<GetOrderingQueryResult>>
    {
    }
}
