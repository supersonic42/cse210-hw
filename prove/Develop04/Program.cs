/*
Project: Mindfulness Program
Author: Anton Sanakoev

Exceeding requirements:
1. 
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> menu = new()
        {
            {1, "Breathing"},
            {2, "Reflecting"},
            {3, "Listing"},
            {4, "Quit"},
        };

        string menuStr = "Which activity you wish to start:\n";

        foreach(KeyValuePair<int, string> menuItem in menu)
        {
            menuStr += "  " + menuItem.Key + ". " + menuItem.Value + "\n";
        }

        menuStr += "Your choice: ";

        int choice = 0;
        List<int> choices = [.. menu.Keys];

        do 
        {
            Console.Clear();
            Console.Write("\n" + menuStr);

            if (int.TryParse(Console.ReadLine(), out choice) == false || choices.Contains(choice) == false)
            {
                Console.WriteLine("\nWrong choice.");
                continue;
            }

            Console.Clear();

            switch(choice)
            {
                case 1:
                    string description = "This activity will help you to relax by walking through breathing in and out slowly.\n";
                    description += "Clear your mind and focus on your breathing.\n\n";

                    BreathingActivity activity = new("Breathing Activity", description, 0);
                    activity.DisplayStartingMessage();
                   
                    int duration = int.Parse(Console.ReadLine());
                    activity.SetDuration(duration);
                    activity.Run();
                    break;
            }
        }
        while(choice != 4);
    }
}