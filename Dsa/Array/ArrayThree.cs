using System;
namespace Dsa
{
    class Array_three
    {
        public static void Main(string[] args)
        {
            int [] numbers = {50 ,40, 30, 20};
            int secondlargest = numbers[0];
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i]>largest)
                {
                    secondlargest = largest;
                    largest = numbers[i];
                }
                else if (numbers[i] > secondlargest && numbers[i] != largest)
                {
                    secondlargest = numbers[i];
                }
            }
            Console.WriteLine("The Second Largest number in the array is:" + secondlargest);
        }
    }
}