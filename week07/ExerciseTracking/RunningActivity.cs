public class RunningActivity : Activity
{
    private int _distance;

    public RunningActivity(string date, int length, int distance) : base(date, length)
    {
        _distance = distance;
    } 

    public override string GetDistance()
    {
        return _distance.ToString();
    }

    public override string GetSpeed()
    {
        double speed = (_distance/GetLength()) * 60;
        return speed.ToString();
    }

    public override string GetPace()
    {
        double pace = GetLength()/_distance;
        return pace.ToString();
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} Running ({GetLength()} min) - Distance {GetDistance()}km, Speed {GetSpeed} kph, Pace {GetPace} min per km");
    }
}