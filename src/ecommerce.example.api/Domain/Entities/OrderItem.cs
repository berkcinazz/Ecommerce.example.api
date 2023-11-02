using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class OrderItem : Entity<int>
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public float Amount { get; set; }
        public int OrderId { get; set; }
        public virtual Product Product { get; set; }
    }
}