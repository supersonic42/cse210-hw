public class GoalManager()
{
    private List<Goal> _goals = [];
    private int _score = 0;

    public void Start()
    {
        Dictionary<int, string> menu = new()
        {
            {1, "Create New Goal"},
            {2, "List Goals"},
            {3, "Save Goals"},
            {4, "Load Goals"},
            {5, "Record Event"},
            {6, "Quit"},
        };

        string menuStr = "What do you want:\n";

        foreach(KeyValuePair<int, string> menuItem in menu)
        {
            menuStr += "  " + menuItem.Key + ". " + menuItem.Value + "\n";
        }

        menuStr += "Your choice: ";

        int choice = 0;
        List<int> choices = [.. menu.Keys];

        do 
        {
            try
            {
                DisplayPlayerInfo();

                Console.Write("\n" + menuStr);

                if (int.TryParse(Console.ReadLine(), out choice) == false || choices.Contains(choice) == false)
                {
                    Console.WriteLine("\nWrong choice.");
                    continue;
                }

                switch(choice)
                {
                    case 1:
                    {
                        CreateGoal();
                    }
                    break;

                    case 2:
                    {
                        ListGoals();
                    }
                    break;

                    case 3:
                    {
                        Console.Write("What is the filename? ");
                        string filename = Console.ReadLine();
                        SaveGoals(filename);
                    }
                    break;

                    case 4:
                    {
                        Console.Write("What is the filename? ");
                        string filename = Console.ReadLine();
                        LoadGoals(filename);
                    }
                    break;

                    case 5:
                    {
                        RecordEvent();
                    }
                    break;
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        while(choice != 6);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }

    public void CreateGoal()
    {
        Dictionary<int, string> goals = new()
        {
            {1, "Simple"},
            {2, "Eternal"},
            {3, "Checklist"},
        };

        Console.WriteLine("The types of Goals are:");

        foreach(KeyValuePair<int, string> goal in goals)
        {
            Console.WriteLine($"  {goal.Key}. {goal.Value}");
        }

        int goalId = 0;
        List<int> goalIds = [.. goals.Keys];

        Console.Write("Which type of goal would you like to create? ");

        if (int.TryParse(Console.ReadLine(), out goalId) == false || goalIds.Contains(goalId) == false)
        {
            Console.WriteLine("Wrong Type.");
            return;
        }

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is the short description of your goal? ");
        string goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());

        switch(goalId)
        {
            case 1:
            {
                SimpleGoal goal = new(goalName, goalDescription, goalPoints);
                _goals.Add(goal);
            }
            break;

            case 2:
            {
                EternalGoal goal = new(goalName, goalDescription, goalPoints);
                _goals.Add(goal);
            }
            break;

            case 3:
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int completionTimesMax = int.Parse(Console.ReadLine());

                Console.Write("What is the accomplishing bonus? ");
                int completionBonus = int.Parse(Console.ReadLine());

                ChecklistGoal goal = new(goalName, goalDescription, goalPoints, completionBonus, completionTimesMax);
                _goals.Add(goal);
            }
            break;
        }

        Console.WriteLine("Goal has been added.");
    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are: ");

        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            Console.WriteLine(goal.GetDetailsString(i + 1));
        }
    }

    public void SaveGoals(string filename)
    {
        using StreamWriter outputFile = new(filename);

        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            outputFile.WriteLine(goal.GetStringRepresentation());
        }
        
        Console.WriteLine("File has been saved.");
    }

    public void LoadGoals(string filename)
    {
        _goals = [];
        _score = 0;

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");

            string goalClassName = parts[0];
            string[] goalData = parts[1].Split(",");

            switch(goalClassName)
            {
                case "SimpleGoal":
                {
                    SimpleGoal goal = SimpleGoal.CreateInstance(goalData);
                    _goals.Add(goal);
                    _score += goal.CalculatePoints();
                }
                break;

                case "EternalGoal":
                {
                    EternalGoal goal = EternalGoal.CreateInstance(goalData);
                    _goals.Add(goal);
                    _score += goal.CalculatePoints();
                }
                break;

                case "ChecklistGoal":
                {
                    ChecklistGoal goal = ChecklistGoal.CreateInstance(goalData);
                    _goals.Add(goal);
                    _score += goal.CalculatePoints();
                }
                break;
            }
        }

        Console.WriteLine("File has been loaded.");
    }

    public void RecordEvent()
    {
        Console.Write("Which goal did you accomplish? ");
        
        int goalNumber = int.Parse(Console.ReadLine());
        int goalIndex = goalNumber - 1;

        if (_goals.ElementAtOrDefault(goalIndex) == null)
        {
            Console.WriteLine("Wrong goal number.");
            return;
        }

        var goal = _goals[goalIndex];

        try
        {
            goal.RecordEvent();

            int points = goal.GetRecordPoints();
            
            _score += points;

            Console.WriteLine($"Congratulations! You have earned {points} points.");
        }
        catch (System.Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}