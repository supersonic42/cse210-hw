public class LectureEvent(
    string title, 
    string description, 
    DateTime dateTime, 
    Address address, 
    string speakerName, 
    int capacity
) : Event (title, description, dateTime, address)
{
    private string _speakerName = speakerName;
    private int _capacity = capacity;

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()} | {GetLiteralType()} | Speaker Name: {_speakerName} | Capacity: {_capacity}";
    }

    protected override string GetLiteralType()
    {
        return "Lecture";
    }
}