using E_CommerceProject.Order.Domain.Entities;

namespace E_CommerceProject.Order.Application.Interfaces
{
    public interface IOrderingRepository
    {
        public List<Ordering> GetOrderingsByUserId(string id);
    }
}
