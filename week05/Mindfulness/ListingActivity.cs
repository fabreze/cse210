public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity() : base()
    {
        _count = 0;
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        bool isValid = false;
        DisplayStartingMessage();
        while (!isValid)
        {
            Console.WriteLine("\nHow long, in seconds, would you like for your session?");
            _duration = int.Parse(Console.ReadLine());

            if (_duration < 10 || _duration % 10 != 0)
            {
                Console.WriteLine("\nPlease select a duration greater than 10 or divisible by 10.");
            }
            else
            {
                isValid = true;
            }
        }

        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> userInput = GetListFromUser();
        _count = userInput.Count;

        Console.WriteLine($"\nYou listed {_count} items!\n");
        Console.WriteLine("Well Done!");
        Console.WriteLine();
        ShowSpinner(5);
        DisplayEndingMessage();
        Thread.Sleep(3000);
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        Console.WriteLine($"--- {_prompts[rand.Next(0, _prompts.Count)]} ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> userInput = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            string input = Console.ReadLine();
            userInput.Add(input);
        }
        return userInput;
    }
}