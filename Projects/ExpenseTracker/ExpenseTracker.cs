using System;
namespace ExpenceTracker
{
    class ExpenseTracker
    {
        public static void Main(string[] args)
        {
            int totalExpenses = 0;
            int[] expenses = { 100, 200, 300, 400, 500 };
            for (int i = 0; i < expenses.Length; i++)
            {
                totalExpenses += expenses[i];
            }
            Console.WriteLine("The Total Expense is:" + totalExpenses);
        }
    }
}