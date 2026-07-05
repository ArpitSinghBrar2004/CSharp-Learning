using System;
namespace Dsa
{
    class Array
    {
        public static void Main(string[] args)
        {
            int [] numbers = {1,2,3,4,5,50};
            int largest = numbers[0];
            for(int i = 1; i <numbers.Length; i++)
            {
                if(numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            Console.WriteLine("The Largest number in the array is:" + largest);
        }
    }
}

