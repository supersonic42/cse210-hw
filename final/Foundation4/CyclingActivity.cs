public class CyclingActivity(int lengthMinutes, DateTime date, float speed) 
: Activity(lengthMinutes, date)
{
    private float _speed = speed;

    protected override string GetLiteralType()
    {
        return "Cycling";
    }

    protected override float GetDistance()
    {
        return _speed * _lengthMinutes / 60;
    }

    protected override float GetPace()
    {
        return 60 / _speed;
    }

    protected override float GetSpeed()
    {
        return _speed;
    }
}