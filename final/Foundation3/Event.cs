public abstract class Event(string title, string description, DateTime dateTime, Address address)
{
    private string _title = title;
    private string _description = description;
    private DateTime _dateTime = dateTime;
    private Address _address = address;

    public abstract string GetFullDetails();

    protected abstract string GetLiteralType();

    public string GetStandardDetails()
    {
        return $"{_title} | {_description} | {GetDateString()} | {GetTimeString()} | {_address.GetDisplayString()}";
    } 

    public string GetShortDescription()
    {
        return $"{GetLiteralType()} | {_title} | {GetDateString()}";
    }

    private string GetDateString()
    {
        return _dateTime.ToString("dd.MM.yyyy");
    }

    private string GetTimeString()
    {
        return _dateTime.ToString("HH:mm");
    }
}