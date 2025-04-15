using System;

class Program
{
    static void Main()
    {
        int previous = 0;
        int count = 0;
        bool isFirstNumber = true;

        Console.WriteLine("Введите последовательность натуральных чисел, завершающуюся 0:");

        while (true)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int current))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число.");
                continue;
            }

            if (current == 0)
            {
                if (isFirstNumber)
                {
                    Console.WriteLine("Последовательность пуста.");
                }
                break;
            }

            if (current < 1)
            {
                Console.WriteLine("Число должно быть натуральным! Повторите ввод.");
                continue;
            }

            if (isFirstNumber)
            {
                previous = current;
                isFirstNumber = false;
            }
            else
            {
                if (current > previous)
                {
                    count++;
                }
                previous = current;
            }
        }

        Console.WriteLine($"Количество элементов, больших предыдущего: {count}");
    }
}
