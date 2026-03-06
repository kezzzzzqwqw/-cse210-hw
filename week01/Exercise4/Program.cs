using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int number = -1;

        while(number != 0)
        { 
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
            
        }
        int sum = 0;

        foreach (int i in numbers)
        {
            sum += i;
        }
    
        Console.WriteLine($"Your sum is {sum}");
            
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largestNumber = numbers[0];

        foreach (int i in numbers)
        {
            if (i > largestNumber)
            {
                largestNumber = i;
            }
        }

        Console.WriteLine($"The largest number is: {largestNumber}");
            


    }
}