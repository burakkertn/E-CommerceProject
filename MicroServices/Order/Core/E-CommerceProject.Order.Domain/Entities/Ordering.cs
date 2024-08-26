using System.ComponentModel.DataAnnotations;

namespace E_CommerceProject.Order.Domain.Entities
{
    public class Ordering
    {
        [Key]
        public int IdOrdering { get; set; }
        public string UserId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
