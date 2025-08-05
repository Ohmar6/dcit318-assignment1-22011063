using System;

class GradeCalculator
{
    static void Main()
    {
        Console.WriteLine("=== Grade Calculator ===");

        // Prompt user for input
        Console.Write("Enter your numerical grade (0–100): ");
        string input = Console.ReadLine();

        // Try to parse input to an integer
        if (int.TryParse(input, out int grade))
        {
            // Validate grade range
            if (grade >= 0 && grade <= 100)
            {
                string letterGrade;

                // Determine letter grade based on scale
                if (grade >= 90)
                    letterGrade = "A";
                else if (grade >= 80)
                    letterGrade = "B";
                else if (grade >= 70)
                    letterGrade = "C";
                else if (grade >= 60)
                    letterGrade = "D";
                else
                    letterGrade = "F";

                Console.WriteLine($"Your letter grade is: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Error: Grade must be between 0 and 100.");
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