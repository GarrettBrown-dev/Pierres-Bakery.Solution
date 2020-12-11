using System;

namespace Bakery.Models
{
    public class Pastry
    {
        public int Price { get; set; }
        public int Quant { get; set; }

        public Pastry(int price, int quant)
        {
            Price = price;
            Quant = quant;
        }

    }
}