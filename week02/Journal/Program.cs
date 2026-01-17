using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        bool isRunning = true;
        Journal journal = new Journal();
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");

            PromptGenerator pGen = new PromptGenerator();
            pGen._prompts.Add("Who was the most interesting person I interacted with today?");
            pGen._prompts.Add("What was the best part of my day?");
            pGen._prompts.Add("How did I see the hand of the Lord in my life today?");
            pGen._prompts.Add("What was the strongest emotion I felt today?");
            pGen._prompts.Add("If I had one thing I could do over today, what would it be?");

            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Entry entry = new Entry();

                    DateTime day = DateTime.Today;
                    entry._date = day.ToShortDateString();

                    entry._promptText = pGen.GetRandomPrompt();
                    Console.WriteLine(entry._promptText);

                    entry._entryText = Console.ReadLine();
                    journal.AddEntry(entry);

                    Console.WriteLine("Entry to Journal Saved!");
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    journal.LoadFromFile("Journal.txt");
                    break;
                case 4:
                    journal.SaveToFile("Journal.txt");
                    break;
                case 5:
                    isRunning = false;
                    Console.WriteLine("Thanks for using the Journal Program! Bye!");
                    break;
                default:
                    Console.WriteLine("ERROR! Please type in a number from the list of options from the menu");
                    break;
            }
        }
        while(isRunning);
    }
}