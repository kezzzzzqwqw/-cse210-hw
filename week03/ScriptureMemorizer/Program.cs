using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference = new Reference("Philippians", 4, 13);
        Scripture scripture = new Scripture(reference, "I can do all things through Christ which strengtheneth me.");

        Console.WriteLine(scripture.GetDisplayText());

        while(true)
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden!");
                break;
            }
        }
    }

}