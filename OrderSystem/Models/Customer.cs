namespace OrderSystem.Models
{
    public class Customer
    {
        private string Name { get; set; }
        private string DeliveryAddress { get; set; }
        private string Contact { get; set; }
        private bool Active { get; set; }
        public ICollection<Order>? orders { get; set; }
    }
}
