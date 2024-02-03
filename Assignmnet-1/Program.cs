using System;

namespace PetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type of pet:");
            Console.WriteLine("1. Cat");
            Console.WriteLine("2. Dog");
            Console.WriteLine("3. Rabbit");

            string petType = Console.ReadLine();

            switch (petType)
            {
                case "1":
                    petType = "Cat";
                    break;
                case "2":
                    petType = "Dog";
                    break;
                case "3":
                    petType = "Rabbit";
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose 1, 2, or 3.");
                    return;
            }
                    Console.WriteLine($"You’ve chosen a {petType}. What would you like to name your pet?");
                    string petName = Console.ReadLine();

                    Console.WriteLine($"Welcome, {petName}! Let’s take good care of him.");
        }
    }
}
