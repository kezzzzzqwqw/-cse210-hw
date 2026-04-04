using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        int userChoice = 0;

        while (userChoice != 4)
        {
            Console.Clear(); 

            Console.WriteLine("Hello World! This is the Mindfulness Project.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();

            while (!int.TryParse(input, out userChoice))
            {
                Console.Write("Invalid input. Enter 1-4: ");
                input = Console.ReadLine();
            }

            if (userChoice == 1)
            {
                new BreathingActivity().Run();
            }
            else if (userChoice == 2)
            {
                new ReflectingActivity().Run();
            }
            else if (userChoice == 3)
            {
                new ListingActivity().Run();
            }
        }
    }

}