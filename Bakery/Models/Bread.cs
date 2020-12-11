using System;

namespace Bakery.Models
{
    public class Bread
    {
        public int Price { get; set; }
        public int Quant { get; set; }
        public Bread(int price, int quant)
        {
            Price = price;
            Quant = quant;
        }

    }
}