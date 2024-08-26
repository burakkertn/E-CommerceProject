

using E_CommerceProject.Order.Application.Features.CQRS.Results.AddressResults;
using E_CommerceProject.Order.Application.Interfaces;
using E_CommerceProject.Order.Domain.Entities;

namespace E_CommerceProject.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class GetAddressQueryHandler
    {
        private readonly IRepository<Address> _repository;
        public GetAddressQueryHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetAddressQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAddressQueryResult
            {
                IdAddress = x.IdAddress,
                City = x.City,
                Detail = x.Detail1,
                District = x.District,
                UserId = x.UserId
            }).ToList();
        }
    }
}
