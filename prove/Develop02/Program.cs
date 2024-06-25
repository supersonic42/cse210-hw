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

        Dictionary<int, string> prompts = new()
        {
            {1, "What did you do to serve God today?"},
            {2, "Did you commit any sin today?"},
            {3, "How many hours did you sleep last night?"},
            {4, "What did you eat today?"},
            {5, "What movie did you see today?"},
        };

        PromptGenerator promptGenerator = new();

        foreach(KeyValuePair<int, string> prompt in prompts)
        {
            promptGenerator._prompts.Add(prompt.Key, prompt.Value);
        }

        int choice = 0;
        List<int> choices = [.. menu.Keys];

        do
        {
            Console.WriteLine(menuStr);
            Console.Write("Select action: ");

            if (int.TryParse(Console.ReadLine(), out choice) == false || choices.Contains(choice) == false)
            {
                Console.WriteLine("Wrong choice.");
                continue;
            }

            switch(choice)
            {
                case 1:
                    string randomPrompt = promptGenerator.GetRandomPrompt();

                    if (randomPrompt != null)
                    {
                        Console.WriteLine($"{randomPrompt}");
                    }
                    else
                    {
                        Console.WriteLine("No prompts...");
                    }

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