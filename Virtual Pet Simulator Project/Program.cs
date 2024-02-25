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
            Pet buddy  = new Pet(petName);
            string userInput;

            do
            {
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine($"1. Feed {petName}");
                Console.WriteLine($"2. Play with {petName}");
                Console.WriteLine($"3. Let {petName} rest");
                Console.WriteLine($"4. Check {petName}'s status");
                Console.WriteLine("5. Exit");
                Console.Write("User Input: ");


                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        buddy.Feed();
                        Console.WriteLine($"{buddy.Name} has been fed. His Hunger decreases, and health improves slightly");
                        break;
                    case "2":
                        buddy.Play();
                        Console.WriteLine($"You played with {buddy.Name}. His happiness increases, but he's a bit hunger");
                        break;
                    case "3":
                        buddy.Rest();
                        Console.WriteLine($"{buddy.Name} is resting.his Hppiness and Health increases");
                        break;
                    case "4":
                        Console.WriteLine(buddy.GetStatus());
                        break;
                    case "5":
                        Console.WriteLine($"Thank You for playing with {buddy.Name}...Exiting");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose a number between 1 and 5.");
                        break;
                }
            }
            while (userInput != "5");
        }
    }
}

public class Pet
{
    public string Name { get; set; }
    public int Hunger { get; private set; }
    public int Happiness { get; private set; }
    public int Health { get; private set; }

    public Pet(string name)
    {
        Name = name;
        Hunger = 10;
        Happiness = 10;
        Health = 10;
    }

    public void Feed()
    {
        Hunger--;
        Health++;
    }

    public void Play()
    {
        Happiness++;
        Hunger++;
    }

    public void Rest()
    {
        Health++;
        Happiness++;
    }

    public string GetStatus()
    {
        return $"{Name}'s status:\n- Hunger: {Hunger}\n- Happiness: {Happiness}\n- Health: {Health}";
    }
}
