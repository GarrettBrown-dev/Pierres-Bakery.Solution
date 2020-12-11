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
        public static int PastryPrice(int quant)
        {
            int newQuant = quant % 3;
            int total = newQuant * 2;
            if (quant > 2)
            {
                int deal = quant / 3;
                total += deal * 5;
            }
            return total;
        }
    }
}