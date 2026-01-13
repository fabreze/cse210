using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Fast Tech";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2010;
        job1._endYear = 2015;

       Job job2 = new Job();
        job2._company = "Innova Tech";
        job2._jobTitle = "Senior Software Engineer";
        job2._startYear = 2015;
        job2._endYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "Fabrizio Caballero";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResumeDetails();
    }
}