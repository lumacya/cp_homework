using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите отсортированный массив целых чисел через пробел:");
        int[] array;
        try
        {
            array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        }
        catch
        {
            Console.WriteLine("Ошибка ввода массива!");
            return;
        }

        Console.WriteLine("Введите значение для поиска:");
        if (!int.TryParse(Console.ReadLine(), out int target))
        {
            Console.WriteLine("Ошибка ввода значения!");
            return;
        }

        int result = BinarySearch(array, target);
        Console.WriteLine(result != -1 ? $"Индекс: {result}" : "NO");
    }

    static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (array[mid] == target)
                return mid;
            else if (array[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
}
