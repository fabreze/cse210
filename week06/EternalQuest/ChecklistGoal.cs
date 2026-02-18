public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _name = name;
        _description = description;
        _points = points;
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted == _target)
        {
            _amountCompleted++;
            Console.WriteLine($"You have earned {_points} points and {_bonus} bonus points!");
        }
        else
        {
            _amountCompleted++;
            Console.WriteLine($"You have earned {_points} points!");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string completionStatus = IsComplete() ? "✓" : " ";
        return $"[{completionStatus}] {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{_name},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public int GetTarget()
    {
        return _target;
    }
    public int GetBonus()
    {
        return _bonus;
    }
}