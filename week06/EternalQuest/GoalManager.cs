public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool isRunning = true;
        do
        {
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu:");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.\n");
                    break;
            }
        }
        while(isRunning);
    }

    public void DisplayPlayerInfo()
    {
        _score = 0;
        foreach(Goal goal in _goals)
        {
            _score += goal.GetPoints();
        }

        Console.WriteLine($"Your current score is: {_score}");
    }

    public void ListGoalNames()
    {
        foreach(Goal goal in _goals){
            Console.WriteLine($"{_goals.IndexOf(goal) + 1} {goal.GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{_goals.IndexOf(goal) + 1}. {goal.GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?");
        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine("What is your goal?");
        string name = Console.ReadLine();

        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal?");
        int points = int.Parse(Console.ReadLine());

        if(choice == 3)
        {
            Console.WriteLine("How many times does this goal need to be completed for a bonus?");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
        else
        {
            if(choice == 1)
            {
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
            }
            else if(choice == 2)
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
            }
        }
    }

    public void RecordEvent()
    {
        bool isValid = false;
        int userInput = 0;

        while (!isValid)
        {
            Console.WriteLine("The goals are:");
            ListGoalNames();
            Console.WriteLine("Which goal did you accomplish?");
            userInput = int.Parse(Console.ReadLine());
            if(userInput > 0 && userInput <= _goals.Count)
            {
                isValid = true;
            }
        }

        if(_goals[userInput - 1] is ChecklistGoal)
        {
            ChecklistGoal checklistGoal = (ChecklistGoal)_goals[userInput - 1];
            if(checklistGoal.GetAmountCompleted() == checklistGoal.GetTarget())
            {
                _score += checklistGoal.GetPoints() + checklistGoal.GetBonus();
            }
            else
            {
                _score += checklistGoal.GetPoints();
            }
            checklistGoal.RecordEvent();
        }
        else
        {
            _score += _goals[userInput - 1].GetPoints();
            _goals[userInput - 1].RecordEvent();
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string filename = Console.ReadLine();
        try
        {
            File.WriteAllText(filename, string.Empty);
            using(FileStream outputFile = new FileStream(filename, FileMode.Create))
            {
                using(StreamWriter writer = new StreamWriter(outputFile))
                {
                    writer.WriteLine(_score);
                    foreach(Goal goal in _goals)
                    {
                        writer.WriteLine(goal.GetStringRepresentation());
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the goals: {ex.Message}");
        }
    }

    public void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file?");
        string filename = Console.ReadLine();
        try
        {
          string[] lines = System.IO.File.ReadAllLines(filename);
          _score = int.Parse(lines[0]);
          for(int i = 1; i < lines.Length; i++)
          {
            string[] parts = lines[i].Split(':');
            string goalType = parts[0];
            string[] attributes = parts[1].Split(',');

            if(goalType == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(attributes[0], attributes[1], int.Parse(attributes[2]));
                if(bool.Parse(attributes[3]))
                {
                    simpleGoal.SetIsComplete(true);
                }
                _goals.Add(simpleGoal);
            }
            else if(goalType == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(attributes[0], attributes[1], int.Parse(attributes[2]));
                _goals.Add(eternalGoal);
            }
            else if(goalType == "CheckListGoal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(attributes[0], attributes[1], int.Parse(attributes[2]), int.Parse(attributes[4]), int.Parse(attributes[5]));
                _goals.Add(checklistGoal);
            }
          }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading the goals: {ex.Message}");
        }
    }
}