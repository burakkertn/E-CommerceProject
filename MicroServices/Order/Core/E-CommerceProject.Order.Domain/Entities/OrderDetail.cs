using System.ComponentModel.DataAnnotations;

namespace E_CommerceProject.Order.Domain.Entities
{
    public class OrderDetail
    {
        [Key]
        public int IdOrderDetail { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductAmount { get; set; }
        public decimal ProductTotalPrice { get; set; }
        public int IdOrdering { get; set; }
        public Ordering Ordering { get; set; }
    }
}
