using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        bool collectingNumbers = true;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (collectingNumbers)
        {
            Console.WriteLine("Enter a number:");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 0)
            {
                collectingNumbers = false;
            }
            else
            {
                numbers.Add(userInput);
            }
        }

        int sum = 0;
        int largestNumber = 0;

        foreach (int number in numbers)
        {
            sum += number;
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        
        float average = (float)sum / (float)numbers.Count;

        Console.WriteLine($"The sum is: {sum}.");
        Console.WriteLine($"The average is: {average}.");
        Console.WriteLine($"The largest number is: {largestNumber}.");
    }
}