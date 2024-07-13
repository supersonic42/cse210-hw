public class Activity(string name, string description, int duration)
{
    protected string _name = name;
    protected string _description = description;
    protected int _duration = duration;
    protected List<string> _spinnerChars = ["|", "/", "-", "\\"];

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        string message = $"Welcome to the {_name}.\n\n";
        message += _description;
        message += "How long in seconds would you like for your session? ";

        Console.Write(message);
    }

    public void DisplayEndingMessage()
    {
        
    }

    public void ShowSpinner(int seconds)
    {
        Console.CursorVisible = false;

        int sleep = 500;
        int steps = seconds * 1000 / sleep;

        for(int i = 0; i < steps; i++)
        {
            int index = i < _spinnerChars.Count() ? i : i % _spinnerChars.Count();

            Console.Write(_spinnerChars[index]);           
            Thread.Sleep(sleep);
            Console.Write("\b \b");
        }

        Console.CursorVisible = true;
    }

    public void ShowCountDown(int seconds)
    {
        Console.CursorVisible = false;

        for (var i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.CursorVisible = true;
    }
}