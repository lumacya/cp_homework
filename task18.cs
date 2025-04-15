using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите натуральное число больше 1:");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 1)
        {
            Console.WriteLine("Ошибка ввода! Требуется число > 1");
            return;
        }

        List<int> factors = PrimeFactorization(n);
        Console.WriteLine($"Простые множители: {FormatFactors(factors)}");
    }

    public static List<int> PrimeFactorization(int number)
    {
        List<int> factors = new List<int>();
        
        // Обработка делителей 2
        while (number % 2 == 0)
        {
            factors.Add(2);
            number /= 2;
        }

        // Обработка нечетных делителей
        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            while (number % i == 0)
            {
                factors.Add(i);
                number /= i;
            }
        }

        // Если остаток - простое число > 2
        if (number > 2)
            factors.Add(number);

        return factors;
    }

    private static string FormatFactors(List<int> factors)
    {
        return factors.Count > 0 ? string.Join(" * ", factors) : "1 (недопустимый случай)";
    }
}
