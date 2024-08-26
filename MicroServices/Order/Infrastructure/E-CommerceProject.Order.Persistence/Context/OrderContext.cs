using E_CommerceProject.Order.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceProject.Order.Persistence.Context
{
    public class OrderContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1434;initial Catalog=ECommerceOrderDb;User=sa;Password=Burak123*!;TrustServerCertificate=True");
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Ordering> Orderings { get; set; }
    }
}
