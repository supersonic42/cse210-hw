public class BreathingActivity(string name, string description, int duration) 
: Activity(name, description, duration)
{
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(2);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        int breatheInDuration = 3;
        int breatheOutDuration = 6;

        while (DateTime.Now < endTime)
        {
            Console.Write("\n\nBreathe in...");
            ShowCountDown(breatheInDuration);

            Console.Write("\nBreathe out...");
            ShowCountDown(breatheOutDuration);
        }
    }
}