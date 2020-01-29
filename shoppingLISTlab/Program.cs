using System;
using System.Collections.Generic;

namespace shoppingLISTlab
{
    class Program
    {
        static void Main(string[] args)
        {
            string grocerieChoice;
            string cont;
            List<string> foods = new List<string>();
            List<double> prices = new List<double>();
            double total = 0;

            Dictionary<string, double> groceryItems = new Dictionary<string, double>();
            {
                groceryItems.Add("Apples", 1.99);
                groceryItems.Add("Bananas", 2.49);
                groceryItems.Add("Carrots", 1.19);
                groceryItems.Add("Donuts", 4.99);
                groceryItems.Add("Eggs", 1.10);
                groceryItems.Add("Flour", 1.49);
                groceryItems.Add("Grapes", 2.79);
                groceryItems.Add("Hamburger", 5.69);
            }

            do
            {
                do
                {
                    Console.Write("Welcome to LB's Market!\n");
                    foreach (KeyValuePair<string, double> items in groceryItems)
                    {
                        Console.WriteLine("{0}: {1}", items.Key, items.Value);
                    }
                    Console.WriteLine($"\nWhich item would you like to add to your cart?:");
                    grocerieChoice = Console.ReadLine();

                    if (!groceryItems.ContainsKey(grocerieChoice))
                    {
                        Console.WriteLine("Invalid Choice, please choose an item on the list");
                    }

                } while (!groceryItems.ContainsKey(grocerieChoice));

                Console.WriteLine($"We have added {grocerieChoice} to your cart, it cost ${groceryItems[grocerieChoice]}!");

                foods.Add(grocerieChoice);
                prices.Add(groceryItems[grocerieChoice]);
                total += groceryItems[grocerieChoice];

                Console.WriteLine();

                Console.WriteLine("Would you like to keep shopping (y/n)?: ");
                cont = Console.ReadLine();

            } while (cont == "y" || cont == "Y");

            Console.WriteLine();


            Console.WriteLine("Your Receipt: ");
            for (int i = 0; i < foods.Count; i++)
            {
                 Console.WriteLine($"{foods[i]} {prices[i]}");
            }

            Console.WriteLine($"Your total: ${total}");
            Console.WriteLine($"The average price price per item in order was ${total / foods.Count}");
            
        }   
    }
}
