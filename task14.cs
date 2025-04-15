using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите целое положительное число:");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int number) || number < 0)
        {
            Console.WriteLine("Ошибка ввода! Необходимо ввести целое неотрицательное число.");
            return;
        }

        int sum = SumOfDigits(number);
        Console.WriteLine($"Сумма цифр: {sum}");
    }

    public static int SumOfDigits(int number)
    {
        if (number < 0)
            throw new ArgumentException("Число должно быть неотрицательным.");

        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}
