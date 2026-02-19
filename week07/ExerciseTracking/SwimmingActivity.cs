public class SwimmingActivity : Activity
{
    private int _numberOfLaps;
    private const int _POOLLAP = 50;
    public SwimmingActivity(string date, int length, int numberOfLaps) : base(date,length)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override string GetDistance()
    {
        double distance = _numberOfLaps * _POOLLAP / 1000;
        return distance.ToString();
    }

    public override string GetSpeed()
    {
        double speed = 60 / Double.Parse(GetPace());
        return speed.ToString();
    }

    public override string GetPace()
    {
        double pace = GetLength() / Double.Parse(GetDistance());
        return pace.ToString();
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} Swimming ({GetLength()} min) - Distance {GetDistance()}km, Speed {GetSpeed} kph, Pace {GetPace} min per km");
    }
}