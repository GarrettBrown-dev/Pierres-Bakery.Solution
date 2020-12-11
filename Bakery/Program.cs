using System;
using Bakery.Models;

namespace Pierre
{
    public class Program
    {
        public static void Main()
        {
            Bread bread = new Bread(0, 0);
            Pastry pastry = new Pastry(0, 0);

            Console.WriteLine("Bonjour! Welcome to Pierre's Bakery! What would you like today mon ami? Can I start you off with some bread? (Please enter yes or no!)");
            string userInputFirst = Console.ReadLine().ToLower();
            {
                if (userInputFirst == "yes")
                {
                    Console.WriteLine("Here's what we've got for bread mo' friar: 1 loaf: $5, but if you buy 2, you get 1 free! Please enter the number you'd like!");
                    string userInputBread = Console.ReadLine();
                    bread.Quant += int.Parse(userInputBread);
                    bread.Price = Bread.BreadPrice(bread.Quant);
                    Console.WriteLine("Great! Your total for this delicious bread is $" + bread.Price);
                }
                else if (userInputFirst == "no") ;
            }
            Console.WriteLine("Wonderful! Would you like any Pastries today? (Yes/No)");
            string userInputSecond = Console.ReadLine();
            {
                if (userInputSecond == "yes")
                {
                    Console.WriteLine("Here are the details for pastries: 1 pastry: $2, but if one buys 3, you can get them for a total of 5$! This is to your liking, non? Go on! Enter a value!");
                    string userInputPastry = Console.ReadLine();
                    pastry.Quant += int.Parse(userInputPastry);
                    pastry.Price = Pastry.PastryPrice(pastry.Quant);
                    Console.WriteLine("Excellent! The total for these delicious pastries is $" + pastry.Price);
                }
                else if (userInputSecond == "no") ;
            }
            Console.WriteLine("Anything else for you? If so type yes! If not, type 'done'!");
            string userInputFinal = Console.ReadLine().ToLower();
            if (userInputFinal == "yes")
            {
                Main();
            }
            else if (userInputFinal == "done")
            {
                int total = bread.Price + pastry.Price;
                Console.WriteLine("Fantastique! Your total is: $" + total);
                Console.WriteLine("Thank you for visiting mon ami! Please come again, and aou revuare!");
            }
            else
            {
                Console.WriteLine("Please enter a valid value!");
            }
        }

    }
}