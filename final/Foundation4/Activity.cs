public class Activity(int lengthMinutes, DateTime date)
{
    protected int _lengthMinutes = lengthMinutes;
    protected DateTime _date = date;

    protected virtual string GetLiteralType()
    {
        return "";
    }

    protected virtual float GetDistance()
    {
        return 0;
    }

    protected virtual float GetPace()
    {
        return 0;
    }

    protected virtual float GetSpeed()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} {GetLiteralType()} ({_lengthMinutes} min): Distance {Math.Round(GetDistance(), 2)}km, Speed {Math.Round(GetSpeed(), 2)}kph, Pace {Math.Round(GetPace(), 2)} min per km";
    }
}