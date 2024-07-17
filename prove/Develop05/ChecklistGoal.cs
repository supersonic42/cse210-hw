public class ChecklistGoal(string name, string description, int points, int completionBonus, int completionTimesMax) :
Goal(name, description, points)
{
    private int _completionTimesMax = completionTimesMax;
    private int _completionBonus = completionBonus;

    public int GetCompletionTimesMax()
    {
        return _completionTimesMax;
    }

    public int GetCompletionBonus()
    {
        return _completionBonus;
    }

    public static ChecklistGoal CreateInstance(string[] data)
    {
        ChecklistGoal obj = new(data[0], data[1], Int32.Parse(data[2]), Int32.Parse(data[3]), Int32.Parse(data[5]));
        obj.SetCompletionTimesCurrent(Int32.Parse(data[4]));

        return obj;
    }

    public override string GetDetailsString(int number)
    {
        string goalCompleteMark = IsComplete() ? "x" : " ";
            
        return $"{number}. [{goalCompleteMark}] {GetName()} ({GetDescription()})"
            + $" | Completed: {GetCompletionTimesCurrent()}/{GetCompletionTimesMax()}";
    }

    public override string GetStringRepresentation()
    {
        List<string> data = [
            GetName(), 
            GetDescription(), 
            GetPoints().ToString(), 
            GetCompletionBonus().ToString(), 
            GetCompletionTimesCurrent().ToString(), 
            GetCompletionTimesMax().ToString()
        ];

        return typeof(ChecklistGoal).Name + ":" + String.Join(",", data);
    }

    public override bool IsComplete()
    {
        return GetCompletionTimesCurrent() == GetCompletionTimesMax();
    }

    public override void RecordEvent()
    {
        if (GetCompletionTimesCurrent() < GetCompletionTimesMax())
        {
            SetCompletionTimesCurrent(GetCompletionTimesCurrent() + 1);
        }
        else
        {
            throw new Exception("You have already completed this goal.");
        }   
    }

    public override int CalculatePoints()
    {
        return GetCompletionTimesCurrent() * GetPoints() + (IsComplete() ? GetCompletionBonus() : 0);
    }

    public override int GetRecordPoints()
    {
        int points = GetPoints();

        if (IsComplete())
        {
            points += GetCompletionBonus();
        }

        return points;
    }
}