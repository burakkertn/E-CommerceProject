﻿using E_CommerceProject.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using E_CommerceProject.Order.Application.Interfaces;
using E_CommerceProject.Order.Domain.Entities;

namespace E_CommerceProject.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class RemoveOrderDetailCommandHandler
    {
        private readonly IRepository<OrderDetail> _repository;
        public RemoveOrderDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveOrderDetailCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.DeleteAsync(value);
        }
    }
}