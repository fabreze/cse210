public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {

    }

    public void DisplayEndingMessage()
    {

    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("—");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < futureTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count())
            {
                i = 0;
            }
        }

        Console.WriteLine("Done!");
    }

    public void ShowCountDown(int seconds)
    {

    }

}