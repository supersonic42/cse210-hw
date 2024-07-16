public class EternalGoal(string name, string description, int points) : Goal(name, description, points)
{
    private int _completionTimesCurrent = 0;

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