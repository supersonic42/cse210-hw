using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Dictionary<int, string> menu = new()
        {
            {1, "Write"},
            {2, "Display"},
            {3, "Load"},
            {4, "Save"},
            {5, "Quit"},
        };

        string menuStr = "\n";

        foreach(KeyValuePair<int, string> menuItem in menu)
        {
            menuStr += menuItem.Key + ". " + menuItem.Value + "\n";
        }

        List<string> prompts = [
            "What did you do to serve God today?",
            "Did you commit any sin today?",
            "How many hours did you sleep last night?",
            "What did you eat today?",
            "What movie did you see today?",
        ];
        
        PromptGenerator promptGenerator = new();

        foreach(string prompt in prompts)
        {
            promptGenerator._prompts.Add(prompt);
        }

        int choice = 0;
        List<int> choices = [.. menu.Keys];

        do
        {
            Console.WriteLine(menuStr);
            Console.Write("Select action: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choices.Contains(choice) == false)
            {
                Console.WriteLine("Wrong choice.");
                continue;
            }

            switch(choice)
            {
                case 1:
                    string randomPrompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine($"{randomPrompt}");
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }
        while (choice != 5);
    }
}