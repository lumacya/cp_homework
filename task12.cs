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

        int minOdd = int.MaxValue;
        foreach (int num in numbers)
        {
            if (num % 2 != 0 && num < minOdd)
            {
                minOdd = num;
            }
        }

        Console.WriteLine(minOdd != int.MaxValue ? minOdd : 0);
    }
}
