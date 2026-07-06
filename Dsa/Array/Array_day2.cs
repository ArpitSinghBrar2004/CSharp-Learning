int[] numbers = {1, 2, 3, 4, 5, 50};
int[] reversedArray = new int[numbers.Length];  // New empty array

for (int i = 0; i < numbers.Length; i++)
{
    reversedArray[i] = numbers[numbers.Length - 1 - i];
}
Console.WriteLine("The Reverse of the array is:");
for (int i = 0; i < reversedArray.Length; i++)
{
    Console.WriteLine(reversedArray[i]);
}