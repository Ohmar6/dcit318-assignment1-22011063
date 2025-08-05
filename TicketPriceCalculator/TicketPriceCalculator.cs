using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.WriteLine("=== Ticket Price Calculator ===");

        // Prompt user for age
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        // Try to parse input to an integer
        if (int.TryParse(input, out int age))
        {
            // Validate age range
            if (age >= 0 && age <= 120)
            {
                int price;

                // Apply discount for seniors (65+) and children (12 and below)
                if (age >= 65 || age <= 12)
                    price = 7;
                else
                    price = 10;

                Console.WriteLine($"Your ticket price is: GHC{price}");
            }
            else
            {
                Console.WriteLine("Error: Please enter a realistic age between 0 and 120.");
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid input. Please enter a number.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}