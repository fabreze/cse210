using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        int gradePercentage = int.Parse(Console.ReadLine());
        int lastDigit = gradePercentage % 10;
        
        string letterGrade = "";
        Boolean passed = false;

        if(gradePercentage >= 90)
        {
            passed = true;
            if (lastDigit < 3 && gradePercentage != 100)
            {
                letterGrade = "A-";
            }
            else
            {
                letterGrade = "A";
            }
        }
        else if (gradePercentage >= 80)
        {
            passed = true;
            if(lastDigit >= 7)
            {
                letterGrade = "B+";
            }
            else if(lastDigit < 3)
            {
                letterGrade = "B-";
            }
            else
            {
                letterGrade = "B";
            }
        }
        else if(gradePercentage >= 70)
        {
            passed = true;
            if(lastDigit >= 7)
            {
                letterGrade = "C+";
            }
            else if(lastDigit < 3)
            {
                letterGrade = "C-";
            }
            else
            {
                letterGrade = "C";
            }
        }
        else if(gradePercentage >= 60)
        {
            if(lastDigit >= 7)
            {
                letterGrade = "D+";
            }
            else if(lastDigit < 3)
            {
                letterGrade = "D-";
            }
            else
            {
                letterGrade = "D";
            }
        }
        else
        {
            letterGrade = "F";
        }

        if (passed)
        {
            Console.WriteLine($"Your grade is: {letterGrade}! Congratulations you passed!");
        }
        else
        {
            Console.WriteLine($"Your grade is: {letterGrade}. You didn't pass, you should study harder.");
        }
    }
}