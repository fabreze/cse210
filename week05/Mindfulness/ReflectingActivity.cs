public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity() : base()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
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

        Console.WriteLine("\nConsider the following prompt\n");
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DisplayQuestions();
        Console.WriteLine();
        Console.WriteLine("Well Done!");
        ShowSpinner(5);
        Console.WriteLine();
        DisplayEndingMessage();
        Thread.Sleep(3000);
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(0, _prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(0, _questions.Count)];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestions()
    {
        int repetitions = 0;
        int maxRepetitions = _duration / 10;
        while (repetitions < maxRepetitions)
        {
            Console.Write(GetRandomQuestion());
            ShowSpinner(10);
            Console.WriteLine();
            repetitions++;
        }
    }
}