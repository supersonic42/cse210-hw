public class EternalGoal(string name, string description, int points) : Goal(name, description, points)
{
    public static EternalGoal CreateInstance(string[] data)
    {
        EternalGoal obj = new(data[0], data[1], Int32.Parse(data[2]));
        obj.SetCompletionTimesCurrent(Int32.Parse(data[3]));

        return obj;
    }

    public override string GetDetailsString(int number)
    {
        string goalCompleteMark = IsComplete() ? "x" : " ";
            
        return $"{number}. [{goalCompleteMark}] {GetName()} ({GetDescription()})"
            + $" | Completed: {GetCompletionTimesCurrent()}";
    }

    public override string GetStringRepresentation()
    {
        List<string> data = [
            GetName(), 
            GetDescription(), 
            GetPoints().ToString(), 
            GetCompletionTimesCurrent().ToString()
        ];

        return typeof(EternalGoal).Name + ":" + String.Join(",", data);
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void RecordEvent()
    {
        SetCompletionTimesCurrent(GetCompletionTimesCurrent() + 1);
    }

    public override int CalculatePoints()
    {
        return GetCompletionTimesCurrent() * GetPoints();
    }

    public override int GetRecordPoints()
    {
        return GetPoints();
    }
}