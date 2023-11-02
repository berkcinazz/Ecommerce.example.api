using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Order : Entity<int>
    {
        public float TotalAmount { get; set; }
        public int UserId { get; set; }
        public virtual List<OrderItem> Items { get; set; }
        public virtual Product Product { get; set; }

    }
}