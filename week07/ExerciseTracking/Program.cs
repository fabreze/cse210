using System;

class Program
{
    static void Main(string[] args)
    {
       List<Activity> activities = new List<Activity>();

       RunningActivity runningActivity1 = new RunningActivity("Jul 03, 2002",120,2000);
       RunningActivity runningActivity2 = new RunningActivity("Jul 16, 2003",400,5000);
       CyclingActivity cyclingActivity1 = new CyclingActivity("Jul 17, 2003", 200, 50);
       CyclingActivity cyclingActivity2 = new CyclingActivity("Jul 18, 2004", 400, 100);
       SwimmingActivity swimmingActivity1 = new SwimmingActivity("Jul 19, 2004", 200, 10);
       SwimmingActivity swimmingActivity2 = new SwimmingActivity("Jul 20, 2005", 400, 15);

       activities.Add(runningActivity1);
       activities.Add(runningActivity2);
       activities.Add(cyclingActivity1);
       activities.Add(cyclingActivity2);
       activities.Add(swimmingActivity1);
       activities.Add(swimmingActivity2);

       foreach(Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}