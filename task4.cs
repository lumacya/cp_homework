using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, -2, 3, 0, 4 };
        int positiveCount = CountPositiveNumbers(numbers);
        Console.WriteLine($"Количество положительных элементов: {positiveCount}");
    }

    static int CountPositiveNumbers(int[] array)
    {
        int count = 0;
        foreach (int number in array)
        {
            if (number > 0)
            {
                count++;
            }
        }
        return count;
    }
}
