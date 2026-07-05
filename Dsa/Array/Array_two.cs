using System;
namespace Dsa
{
    class Array_two
    {
        public static void Main(string[] args)
        {
            int [] numbers = {1,2,3,4,5,50};
            int smallest = numbers[0];
            for(int i = 1; i <numbers.Length; i++)
            {
                if(numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }
            Console.WriteLine("The Smallest number in the array is:" + smallest);
        }
    }
}