using E_CommerceProject.Order.Application.Features.Mediator.Queries.OrderingQueries;
using E_CommerceProject.Order.Application.Features.Mediator.Results.OrderingResults;
using E_CommerceProject.Order.Application.Interfaces;
using E_CommerceProject.Order.Domain.Entities;
using MediatR;

namespace E_CommerceProject.Order.Application.Features.Mediator.Handlers.OrderingHandlers
{
    public class GetOrderingByIdQueryHandler : IRequestHandler<GetOrderingByIdQuery, GetOrderingByIdQueryResult>
    {
        private readonly IRepository<Ordering> _repository;
        public GetOrderingByIdQueryHandler(IRepository<Ordering> repository)
        {
            _repository = repository;
        }
        public async Task<GetOrderingByIdQueryResult> Handle(GetOrderingByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetOrderingByIdQueryResult
            {
                OrderDate = values.OrderDate,
                IdOrdering = values.IdOrdering,
                TotalPrice = values.TotalPrice,
                UserId = values.UserId
            };
        }
    }
}
