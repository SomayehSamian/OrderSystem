namespace OrderSystem.Models
{
    public class OrderDetail
    {
        private int qty;
        private string taxStatus;

        public Order order { get; set; }
        public ICollection<Item> items { get; set; }

        public void CalculateSubTotal()
        { }
        public void CalculateWaight()
        { }
    }
}
