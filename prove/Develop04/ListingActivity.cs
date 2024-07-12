public class ListingActivity(string name, string description, int duration, int count, List<string> prompts) 
: Activity(name, description, duration)
{
    private int _count = count;
    private List<string> _prompts = prompts;

    public void GetRandomPrompt()
    {

    }

    public List<string> GetListFromUser()
    {
        return [];
    }
}