using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите натуральное число n ≥ 1:");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
        {
            Console.WriteLine("Ошибка ввода!");
            return;
        }

        int result = FindNumberWithMaxDivisorsSum(n);
        Console.WriteLine($"Число с максимальной суммой делителей: {result}");
    }

    public static int FindNumberWithMaxDivisorsSum(int n)
    {
        if (n == 1) return 1;

        int[] sumDivisors = new int[n + 1];

        // Заполняем массив сумм делителей
        for (int d = 1; d <= n; d++)
        {
            for (int k = d; k <= n; k += d)
            {
                sumDivisors[k] += d;
            }
        }

        // Находим максимум и минимальное число с этой суммой
        int maxSum = 0;
        int result = 1;

        for (int i = 1; i <= n; i++)
        {
            if (sumDivisors[i] > maxSum || 
                (sumDivisors[i] == maxSum && i < result))
            {
                maxSum = sumDivisors[i];
                result = i;
            }
        }

        return result;
    }
}
