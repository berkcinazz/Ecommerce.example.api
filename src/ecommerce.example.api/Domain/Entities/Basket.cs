using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Basket : Entity<int>
    {
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
    }
}