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
        public static int BreadPrice(int quant)
        {
            int newQuant = quant % 3;
            int total = newQuant * 5;
            if (quant > 2)
            {
                int deal = quant / 3;
                total += deal * 10;
            }
            return total;
        }

    }
}