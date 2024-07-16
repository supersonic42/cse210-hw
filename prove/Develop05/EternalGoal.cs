public class EternalGoal(string name, string description, int points) : Goal(name, description, points)
{
    private int _completionTimesCurrent = 0;

    public static EternalGoal CreateInstance(string[] data)
    {
        EternalGoal obj = new(data[0], data[1], Int32.Parse(data[2]));
        obj.SetCompletionTimesCurrent(Int32.Parse(data[3]));

        return obj;
    }

    public void SetCompletionTimesCurrent(int count)
    {
        _completionTimesCurrent = count;
    }

    public override string GetStringRepresentation()
    {
        List<string> data = [_name, _description, _points.ToString(), _completionTimesCurrent.ToString()];

        return typeof(EternalGoal).Name + ":" + String.Join(",", data);
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
}