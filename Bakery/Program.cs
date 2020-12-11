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
        }
    }



}