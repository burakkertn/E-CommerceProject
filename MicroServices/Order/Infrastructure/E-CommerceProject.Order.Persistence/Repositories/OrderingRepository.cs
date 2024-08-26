using E_CommerceProject.Order.Application.Interfaces;
using E_CommerceProject.Order.Domain.Entities;
using E_CommerceProject.Order.Persistence.Context;

namespace E_CommerceProject.Order.Persistence.Repositories
{
    public class OrderingRepository : IOrderingRepository
    {
        private readonly OrderContext _orderContext;
        public OrderingRepository(OrderContext orderContext)
        {
            _orderContext = orderContext;
        }
        public List<Ordering> GetOrderingsByUserId(string id)
        {
            var values = _orderContext.Orderings.Where(x => x.UserId == id).ToList();
            return values;
        }
    }
}
