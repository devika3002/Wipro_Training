using System;
using ExceptionHandlingExample;

Console.WriteLine("Exception Handling Example");

try
{
    BankAccount account = new BankAccount();

    Console.WriteLine("Enter transaction amount:");
    decimal amount = Convert.ToDecimal(Console.ReadLine());

    account.MakeTransaction(amount);
}
catch (DailyLimitExceededException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
catch (Exception)
{
    Console.WriteLine("General error occurred.");
}
finally
{
    Console.WriteLine("Execution completed.");
}
