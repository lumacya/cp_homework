using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите два целых числа:");
        
        int a = ReadNumber("Первое число: ");
        int b = ReadNumber("Второе число: ");

        int gcd = EuclidGCD(a, b);
        Console.WriteLine($"НОД({a}, {b}) = {gcd}");
    }

    public static int EuclidGCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    private static int ReadNumber(string prompt)
    {
        int number;
        Console.Write(prompt);
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Ошибка ввода! Введите целое число.");
            Console.Write(prompt);
        }
        return number;
    }
}
