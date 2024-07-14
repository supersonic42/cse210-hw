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
                {
                    string description = "This activity will help you relax by walking your through breathing in and out slowly.\n";
                    description += "Clear your mind and focus on your breathing.";

                    BreathingActivity activity = new("Breathing Activity", description, 0);
                    activity.DisplayStartingMessage();
                   
                    int duration = int.Parse(Console.ReadLine());
                    activity.SetDuration(duration);
                    activity.Run();
                }
                break;

                case 2:
                {
                    string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

                    List<string> prompts = [
                        "Think of a time when you stood up for someone else",
                        "Think of a time when you did something really difficult",
                        "Think of a time when you helped someone in need",
                        "Think of a time when you did something truly selfless",
                    ];

                    List<string> questions = [
                        "Why was this experience meaningful to you?",
                        "Have you ever done anything like this before?",
                        "How did you get started?",
                        "How did you feel when it was complete?",
                        "What made this time different than other times when you were not as successful?",
                        "What is your favorite thing about this experience?",
                        "What could you learn from this experience that applies to other situations?",
                        "What did you learn about yourself through this experience?",
                        "How can you keep this experience in mind in the future?",
                    ];

                    ReflectingActivity activity = new("Reflecting Activity", description, 0, prompts, questions);
                    activity.DisplayStartingMessage();

                    int duration = int.Parse(Console.ReadLine());
                    activity.SetDuration(duration);
                    activity.Run();
                }
                break;
            }
        }
        while(choice != 4);
    }
}