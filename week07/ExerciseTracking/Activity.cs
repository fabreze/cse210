public abstract class Activity
{
    protected string _date;
    protected int _length;

    public Activity(string date, int length){
        _date = date;
        _length = length;
    }

    public abstract string GetDistance();

    public abstract string GetSpeed();

    public abstract string GetPace();

    public abstract void GetSummary();

    public int GetLength()
    {
        return _length;
    }

    public string GetDate()
    {
        return _date;
    }
}