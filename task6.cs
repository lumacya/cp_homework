using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int number))
        {
            Console.WriteLine("Ошибка ввода");
            return;
        }

        string digits = Math.Abs(number).ToString(); // Убираем знак и преобразуем в строку
        bool allSame = true;

        if (digits.Length > 0)
        {
            char firstDigit = digits[0];
            foreach (char digit in digits)
            {
                if (digit != firstDigit)
                {
                    allSame = false;
                    break;
                }
            }
        }
        else
        {
            allSame = false;
        }

        Console.WriteLine(allSame ? "Да" : "Нет");
    }
}
