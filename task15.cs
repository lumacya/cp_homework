using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите числа через пробел:");
        int[] numbers;
        try
        {
            numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }
        catch
        {
            Console.WriteLine("Ошибка ввода!");
            return;
        }

        double average = CalculateAverageOfPositiveEvenNumbers(numbers);
        Console.WriteLine($"Среднее арифметическое: {average:F2}");
    }

    public static double CalculateAverageOfPositiveEvenNumbers(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            return 0;

        int sum = 0;
        int count = 0;

        foreach (int num in numbers)
        {
            if (num > 0 && num % 2 == 0)
            {
                sum += num;
                count++;
            }
        }

        return count > 0 ? (double)sum / count : 0;
    }
}
