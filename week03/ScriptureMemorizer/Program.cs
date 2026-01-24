using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("2 Nephi", 31, 20);
        Scripture scripture = new Scripture(reference, "Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press forward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life.");

        bool isRunning = true;

        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                isRunning = false;
            }
            else
            {
                scripture.HideRandomWords(3);
                if(scripture.isCompletelyHidden())
                {
                    isRunning = false;
                }
            }
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }
        while (isRunning);
    }
}