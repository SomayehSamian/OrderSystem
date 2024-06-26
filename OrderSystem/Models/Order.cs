using OrderSystem.Enums;

namespace OrderSystem.Models
{
    public class Order
    {
        private DateTime createDate;
        public OrderStatus orderStatus { get; set; }
        public Customer customer { get; set; }
        public ICollection<OrderDetail> orderDetails { get; set; }
        public ICollection<Payment> payment { get; set; }

    }
}
