using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        int[] numbers = ReadArray();
        
        if (numbers.Length == 0)
        {
            Console.WriteLine("Массив пуст.");
            return;
        }

        int min = FindMin(numbers);
        int max = FindMax(numbers);
        
        ReplaceMin(numbers, min);
        ReplaceMax(numbers, max);
        
        Console.WriteLine("Результат:");
        PrintArray(numbers);
    }

    static int[] ReadArray()
    {
        string input = Console.ReadLine();
        string[] parts = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        int[] array = new int[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            array[i] = int.Parse(parts[i]);
        }
        return array;
    }

    static int FindMin(int[] array)
    {
        int min = array[0];
        foreach (int num in array)
        {
            if (num < min) min = num;
        }
        return min;
    }

    static int FindMax(int[] array)
    {
        int max = array[0];
        foreach (int num in array)
        {
            if (num > max) max = num;
        }
        return max;
    }

    static void ReplaceMin(int[] array, int minValue)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == minValue) array[i] = 0;
        }
    }

    static void ReplaceMax(int[] array, int maxValue)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == maxValue) array[i] = 99;
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
