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
        }
    }



}