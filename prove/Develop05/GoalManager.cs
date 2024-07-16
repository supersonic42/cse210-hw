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

        DisplayPlayerInfo();

        do 
        {
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
                }
                break;

                case 4:
                {
                }
                break;

                case 5:
                {
                }
                break;
            }
        }
        while(choice != 6);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    // public void ListGoalnames()
    // {

    // }

    // public void ListGoalDetails()
    // {

    // }

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

        switch(goalId)
        {
            case 1:
            {
                Console.Write("What is the name of your goal? ");
                string goalName = Console.ReadLine();

                Console.Write("What is the short description of your goal? ");
                string goalDescription = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                int goalPoints = int.Parse(Console.ReadLine());

                SimpleGoal goal = new(goalName, goalDescription, goalPoints);

                _goals.Add(goal);
            }
            break;

            case 2:
            {
                
            }
            break;
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("The goals are: ");

        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            string goalCompleteMark = goal.IsComplete() ? "x" : "";
            
            Console.WriteLine($"{i + 1}. [{goalCompleteMark}] {goal.GetName()} ({goal.GetDescription()})");
        }
    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }

    public void RecordEvent()
    {

    }
}