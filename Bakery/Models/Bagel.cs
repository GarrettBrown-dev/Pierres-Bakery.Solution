namespace Bakery.Models
{
    public class Bagel
    {
        public int Price { get; set; }
        public int Quant { get; set; }

        public Bagel(int price, int quant)
        {
            Price = price;
            Quant = quant;
        }
        public static int BagelPrice(int quant)
        {
            int newQuant = quant % 4;
            int total = newQuant * 2;
            if (quant > 4)
            {
                int deal = quant / 4;
                total += deal * 4;
            }
            return total;
        }
    }
}