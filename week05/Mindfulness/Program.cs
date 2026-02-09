using System;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("     1. Start breathing activity");
            Console.WriteLine("     2. Start reflecting activity");
            Console.WriteLine("     3. Start listing activity");
            Console.WriteLine("     4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    Console.Clear();
                    breathingActivity.Run();
                    break;
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    Console.Clear();
                    reflectingActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    Console.Clear();
                    listingActivity.Run();
                    break;
                case "4":
                    isRunning = false;
                    break;
            }

        } while (isRunning);
    }
}