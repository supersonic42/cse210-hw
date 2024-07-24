public class RunningActivity(int lengthMinutes, DateTime date, float distance) 
: Activity(lengthMinutes, date)
{
    private float _distance = distance;

    protected override string GetLiteralType()
    {
        return "Running";
    }

    protected override float GetDistance()
    {
        return _distance;
    }

    protected override float GetPace()
    {
        return _lengthMinutes / _distance;
    }

    protected override float GetSpeed()
    {
        return 60 / GetPace();
    }
}