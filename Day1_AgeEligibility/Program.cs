using System;

class AgeEligibility
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
