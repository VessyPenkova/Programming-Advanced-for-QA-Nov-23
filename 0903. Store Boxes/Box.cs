using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0903._Store_Boxes
{
    public class Box
    {
        public Box(string serilaNumber, Item item, int itemQuantity)
        {
            SerialNumber = serilaNumber;
            Item = item;
            ItemQuantity = itemQuantity;
            PriceforBox = item.Price * itemQuantity;
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }

        public decimal PriceforBox { get; set; }
    }
}
