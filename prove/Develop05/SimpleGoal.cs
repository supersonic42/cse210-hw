public class SimpleGoal(string name, string description, int points) : Goal(name, description, points)
{
    public static SimpleGoal CreateInstance(string[] data)
    {
        SimpleGoal obj = new(data[0], data[1], Int32.Parse(data[2]));
        obj.SetCompletionTimesCurrent(Int32.Parse(data[3]));

        return obj;
    }

    public override string GetStringRepresentation()
    {
        List<string> data = [
            GetName(), 
            GetDescription(), 
            GetPoints().ToString(), 
            GetCompletionTimesCurrent().ToString()
        ];

        return typeof(SimpleGoal).Name + ":" + String.Join(",", data);
    }

    public override bool IsComplete()
    {
        return GetCompletionTimesCurrent() == 1;
    }

    public override void RecordEvent()
    {
        if (GetCompletionTimesCurrent() == 0)
        {
            SetCompletionTimesCurrent(1);
        }
        else
        {
            throw new Exception("You have already completed this goal.");
        }
    }

    public override int CalculatePoints()
    {
        return IsComplete() ? GetPoints() : 0;
    }

    public override int GetRecordPoints()
    {
        return GetPoints();
    }
}