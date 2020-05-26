using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Diagnostics;
using System.Reflection;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello sir this is taco bell drive through. We currently have a special to make a random taco, would you like this? y/n:");
            string answer = Console.ReadLine();
            string[] tacotoppings = { "Meat", "Salsa", "Beans", "Sour cream", "Guacamole", "Tomatoes", "Lettuce" };
            if (answer == "y")
            {
                Random rand = new Random();
                int index = rand.Next(tacotoppings.Length);
                Console.WriteLine($"Your taco contains {tacotoppings[index]}");
            }
            else _ = (answer == "n");
                    {
                Console.WriteLine("Sorry sir, the only taco available is the special taco.");

            }
            

        }
    }
}
