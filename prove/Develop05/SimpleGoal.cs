public class SimpleGoal(string name, string description, int points) : Goal(name, description, points)
{
    private bool _isComplete = false;

    public static SimpleGoal CreateInstance(string[] data)
    {
        SimpleGoal obj = new(data[0], data[1], Int32.Parse(data[2]));
        obj.SetIsComplete(bool.Parse(data[3]));

        return obj;
    }

    public override string GetStringRepresentation()
    {
        List<string> data = [_name, _description, _points.ToString(), IsComplete().ToString()];

        return typeof(SimpleGoal).Name + ":" + String.Join(",", data);
    }

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
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