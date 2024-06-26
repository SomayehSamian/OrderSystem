namespace OrderSystem.Models
{
    public class Credit : Payment
    {
        private string number { get; set; }
        private string type { get; set; }
        private DateTime expireDate { get; set; }
    }
}
