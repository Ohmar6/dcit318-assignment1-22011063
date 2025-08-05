using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.WriteLine("=== Triangle Type Identifier ===");

        // Prompt user for the three sides
        Console.Write("Enter side A: ");
        string inputA = Console.ReadLine();

        Console.Write("Enter side B: ");
        string inputB = Console.ReadLine();

        Console.Write("Enter side C: ");
        string inputC = Console.ReadLine();

        // Try to parse all inputs to numbers
        if (double.TryParse(inputA, out double a) &&
            double.TryParse(inputB, out double b) &&
            double.TryParse(inputC, out double c))
        {
            // Check for valid triangle using triangle inequality theorem
            if (a > 0 && b > 0 && c > 0 &&
                a + b > c && a + c > b && b + c > a)
            {
                string triangleType;

                if (a == b && b == c)
                    triangleType = "Equilateral";
                else if (a == b || b == c || a == c)
                    triangleType = "Isosceles";
                else
                    triangleType = "Scalene";

                Console.WriteLine($"The triangle is: {triangleType}");
            }
            else
            {
                Console.WriteLine("Error: The sides do not form a valid triangle.");
            }
        }
        else
        {
            Console.WriteLine("Error: Invalid input. Please enter numeric values.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}