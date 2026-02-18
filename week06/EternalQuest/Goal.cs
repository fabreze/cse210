public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string completionStatus = IsComplete() ? "✓" : " ";
        return $"[{completionStatus}] {_name} ({_description})";
    }

    public abstract string GetStringRepresentation();

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }
}