using System.Numerics;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on yoour breathing.";
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

        int repetitions = 0;
        int maxRepetitions = _duration / 10;
        while (repetitions < maxRepetitions)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(5);
            Console.WriteLine();
            repetitions++;
        }

        Console.WriteLine();
        Console.WriteLine("Well Done!");
        ShowSpinner(5);
        Console.WriteLine();
        DisplayEndingMessage();
        Thread.Sleep(3000);
    }
}