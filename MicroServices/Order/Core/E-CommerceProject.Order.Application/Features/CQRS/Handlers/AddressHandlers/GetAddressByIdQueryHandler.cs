using E_CommerceProject.Order.Application.Features.CQRS.Queries.AddressQueries;
using E_CommerceProject.Order.Application.Features.CQRS.Results.AddressResults;
using E_CommerceProject.Order.Application.Interfaces;
using E_CommerceProject.Order.Domain.Entities;

namespace E_CommerceProject.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class GetAddressByIdQueryHandler
    {
        private readonly IRepository<Address> _repository;
        public GetAddressByIdQueryHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }
        public async Task<GetAddressByIdQueryResult> Handle(GetAddressByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetAddressByIdQueryResult
            {
                IdAddress = values.IdAddress,
                City = values.City,
                Detail = values.Detail1,
                District = values.District,
                UserId = values.UserId
            };
        }
    }
}
