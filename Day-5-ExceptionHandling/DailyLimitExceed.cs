using System;

namespace ExceptionHandlingExample
{
    public class DailyLimitExceededException : Exception
    {
        public DailyLimitExceededException(string message) : base(message)
        {
        }
    }

    class BankAccount
    {
        private decimal dailyLimit = 1000;
        private decimal totalTransactionsToday = 0;

        public void MakeTransaction(decimal amount)
        {
            if (totalTransactionsToday + amount > dailyLimit)
            {
                throw new DailyLimitExceededException("Transaction exceeds daily limit.");
            }

            totalTransactionsToday += amount;
            Console.WriteLine($"Transaction of {amount} successful. Total today: {totalTransactionsToday}");
        }
    }
}