public class SimpleGoal(string name, string description, int points) : Goal(name, description, points)
{
    private bool _isComplete = false;

    public override string GetStringRepresentation()
    {
        List<string> data = [_name, _description, _points.ToString(), IsComplete().ToString()];

        return typeof(SimpleGoal).Name + ":" + String.Join(",", data);
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
    }
}