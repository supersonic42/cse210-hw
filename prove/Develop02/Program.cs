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

        Journal journal = new();

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
                    KeyValuePair<int, string> randomPrompt = promptGenerator.GetRandomPrompt();

                    if (randomPrompt.Equals(default(KeyValuePair<int, string>)))
                    {
                        Console.WriteLine("No prompts...");
                    }
                    else
                    {
                        Console.WriteLine($"\n{randomPrompt.Value}");
                        Console.Write("Your answer: ");
                        string entryText = Console.ReadLine();

                        Entry entry = new()
                        {
                            _promptId = randomPrompt.Key,
                            _entryText = entryText,
                            _date = DateTime.Now,
                        };

                        journal.AddEntry(entry);
                    }

                    break;
                case 2:
                    journal.DisplayAll(prompts);
                    break;
                case 3:
                    break;
                case 4:
                    Console.Write("Type filename: ");
                    string filename = Console.ReadLine();
                    journal.SaveToFile(filename);
                    break;
            }
        }
        while (choice != 5);
    }
}