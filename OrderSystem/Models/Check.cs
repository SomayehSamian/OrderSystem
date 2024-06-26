namespace OrderSystem.Models
{
    public class Check : Payment
    {
        private string name { get; set; }
        private string bankID { get; set; }

        public void Authorized()
        { 
        }
    }
}
