using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите числа через пробел:");
        try
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] result = FindElementsEqualToSumOfNeighbors(numbers);
            
            Console.WriteLine("Результат: " + (result.Length > 0 ? string.Join(" ", result) : "Нет подходящих элементов"));
        }
        catch
        {
            Console.WriteLine("Ошибка ввода!");
        }
    }

    public static int[] FindElementsEqualToSumOfNeighbors(int[] array)
    {
        List<int> result = new List<int>();
        
        if (array == null || array.Length < 3)
            return result.ToArray();

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] == array[i - 1] + array[i + 1])
                result.Add(array[i]);
        }
        
        return result.ToArray();
    }
}
