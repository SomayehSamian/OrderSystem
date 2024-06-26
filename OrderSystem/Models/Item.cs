using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Models
{
    public class Item
    {
        private  float weight { get; set; }
        private  string description { get; set; }
        public OrderDetail? orderDetail { get; set; }

        public void GetPriceForquantity()
        { }
        public void GetWeight()
        { }
    }
}
