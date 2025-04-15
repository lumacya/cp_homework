using System;

class Program
{
    static void Main()
    {
        int a, b;
        
        // Ввод и проверка коэффициента a
        Console.Write("Введите коэффициент a: ");
        while (!int.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Ошибка ввода! Введите целое число.");
            Console.Write("Введите коэффициент a: ");
        }

        // Ввод и проверка коэффициента b
        Console.Write("Введите коэффициент b: ");
        while (!int.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Ошибка ввода! Введите целое число.");
            Console.Write("Введите коэффициент b: ");
        }

        // Решение уравнения
        if (a != 0)
        {
            if (b % a == 0)
            {
                int x = b / a;
                Console.WriteLine($"Решение: x = {x}");
            }
            else
            {
                Console.WriteLine("Нет целочисленных решений.");
            }
        }
        else // a == 0
        {
            if (b == 0)
            {
                Console.WriteLine("Решение: x - любое целое число.");
            }
            else
            {
                Console.WriteLine("Нет решений.");
            }
        }
    }
}
