using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = [];
        
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Part 1: Compute the sum
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        // Part 2: Compute the average
        float average = (float) sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the max        
        int max = numbers.Max();
        Console.WriteLine($"The max is: {max}");
    }
}