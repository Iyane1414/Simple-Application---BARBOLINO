using System;

namespace SimpleCSharpApplication;

internal class Program
{
    static void Main()
    {
        Console.Title = "Simple C# Application - Grocery Budget Checker";

        Console.WriteLine("==========================================");
        Console.WriteLine("      Grocery Budget Checker");
        Console.WriteLine("==========================================");
        Console.WriteLine();

        Console.Write("Enter your name: ");
        string userName = Console.ReadLine() ?? "Student";

        decimal budget = ReadDecimal("Enter your total budget: ");
        decimal riceCost = ReadDecimal("Enter the cost of rice: ");
        decimal breadCost = ReadDecimal("Enter the cost of bread: ");
        decimal milkCost = ReadDecimal("Enter the cost of milk: ");

        decimal totalExpenses = riceCost + breadCost + milkCost;
        decimal remainingBalance = budget - totalExpenses;

        Console.WriteLine();
        Console.WriteLine("=========== Budget Summary ===========");
        Console.WriteLine($"Name: {userName}");
        Console.WriteLine($"Total Budget: {budget:C}");
        Console.WriteLine($"Total Expenses: {totalExpenses:C}");
        Console.WriteLine($"Remaining Balance: {remainingBalance:C}");

        if (remainingBalance > 0)
        {
            Console.WriteLine("Status: You are within your budget.");
        }
        else if (remainingBalance == 0)
        {
            Console.WriteLine("Status: You used your budget exactly.");
        }
        else
        {
            Console.WriteLine("Status: You are over your budget.");
        }

        Console.WriteLine("======================================");
        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static decimal ReadDecimal(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (decimal.TryParse(input, out decimal value) && value >= 0)
            {
                return value;
            }

            Console.WriteLine("Invalid input. Please enter a valid non-negative number.");
        }
    }
}
