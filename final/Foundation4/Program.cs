using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = [];

        RunningActivity runningActivity = new(30, new DateTime(2024, 07, 24, 10, 10, 10), 4.8F);
        activities.Add(runningActivity);

        CyclingActivity cyclingActivity = new(60, new DateTime(2024, 07, 24, 12, 12, 12), 10F);
        activities.Add(cyclingActivity);

        SwimmingActivity swimmingActivity = new(90, new DateTime(2024, 07, 24, 14, 14, 14), 30);
        activities.Add(swimmingActivity);

        int index = 0;

        foreach (Activity activity in activities)
        {
            index++;

            Console.WriteLine($"\nActivity #{index}:");
            Console.WriteLine(activity.GetSummary());
        }
    }
}