public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
    }
    public override string GetDistance()
    {
        double distance = _speed * GetLength() / 60;
        return distance.ToString();
    }
    public override string GetSpeed()
    {
        return _speed.ToString();
    }

    public override string GetPace()
    {
        double pace = 60/_speed;
        return pace.ToString();
    }
    public override void GetSummary()
    {
        Console.WriteLine($"{GetDate()} Cycling ({GetLength()} min) - Distance {GetDistance()}km, Speed {GetSpeed} kph, Pace {GetPace} min per km");
    }
}