/*
Project: Scripture Memorizer
Author: Anton Sanakoev

Exceeding requirements:
1. Program randomly selects words to hide from only those, that are not already hidden.
*/
using System;

class Program
{
    private const int WORDS_TO_HIDE = 3;

    static void Main(string[] args)
    {
        string choice = "";

        Scripture scripture = new(new Reference("Matthew", 6, 33, 34), "But seek first his kingdom and his righteousness, and all these things will be given to you as well. Therefore do not worry about tomorrow, for tomorrow will worry about itself. Each day has enough trouble of its own.");

        do
        {
            ShowScripture(scripture);
            scripture.HideRandomWords(WORDS_TO_HIDE);
            choice = Console.ReadLine();
        }
        while (choice != "quit" && !scripture.IsCompletelyHidden());

        if (scripture.IsCompletelyHidden())
        {
            ShowScripture(scripture);
        }
    }

    private static void ShowScripture(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine($"{scripture.GetDisplayText()}\n");
        Console.WriteLine("Press enter to continue or 'quit' to finish:");
    }
}