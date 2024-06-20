using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 7, 2, 9, 1 };
        int maxNumber = FindMaxNumber(numbers);
        Console.WriteLine($"Наибольшее значение в массиве: {maxNumber}");
    }

    static int FindMaxNumber(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
}
