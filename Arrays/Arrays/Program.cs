using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Hello sir this is taco bell drive through. We currently have a special to make a random taco, would you like this? y/n:");
                string answer = Console.ReadLine(); //reading the console input 
                string[] tacotoppings = { "Meat", "Salsa", "Beans", "Sour cream", "Guacamole", "Tomatoes", "Lettuce" }; //my array of taco toppings
                Random rand = new Random(); //random selection
                int index = rand.Next(tacotoppings.Length); //randomizer one
                int index2 = rand.Next(tacotoppings.Length); //randomizer two

                if (answer == "y")
                    {
                        Console.WriteLine($"Your taco contains: \n{tacotoppings[index]}\n{tacotoppings[index2]}");
                    }


                else if ($"index1" == "index2")
                    {
                        Console.WriteLine($"Your taco contains: \n Double {tacotoppings[index]}");
                    }


                else if (answer == "n")
                    {
                        Console.WriteLine("Sorry sir, the only taco available is the special taco.");//If you get the same topping you get "double"

                    }
        }
                


        }
    }
