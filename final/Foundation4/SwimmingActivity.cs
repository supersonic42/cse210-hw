public class SwimmingActivity(int lengthMinutes, DateTime date, int lapsCount) 
: Activity(lengthMinutes, date)
{
    private int _lapsCount = lapsCount;

    protected override string GetLiteralType()
    {
        return "Swimming";
    }

    protected override float GetDistance()
    {
        return _lapsCount * 50F / 1000;
    }

    protected override float GetPace()
    {
        return _lengthMinutes / GetDistance();
    }

    protected override float GetSpeed()
    {
        return 60 / GetPace();
    }
}