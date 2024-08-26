using E_CommerceProject.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using E_CommerceProject.Order.Application.Interfaces;
using E_CommerceProject.Order.Domain.Entities;

namespace E_CommerceProject.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class CreateOrderDetailCommandHandler
    {
        private readonly IRepository<OrderDetail> _repository;

        public CreateOrderDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateOrderDetailCommand command)
        {
            await _repository.CreateAsync(new OrderDetail
            {
                ProductAmount = command.ProductAmount,
                IdOrdering = command.IdOrdering,
                ProductId = command.ProductId,
                ProductName = command.ProductName,
                ProductPrice = command.ProductPrice,
                ProductTotalPrice = command.ProductTotalPrice
            });
        }
    }
}
