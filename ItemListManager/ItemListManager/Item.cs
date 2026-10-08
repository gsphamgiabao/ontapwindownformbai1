using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemListManager
{
    public class Item
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }

        public Item() { }

        public Item(string code, string name, string unit, decimal price)
        {
            ItemCode = code;
            ItemName = name;
            Unit = unit;
            Price = price;
        }
    }
}
