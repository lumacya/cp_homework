using System;

class Program
{
    static void Main()
    {
        int maxCount = 0;     // Максимальное количество подряд идущих
        int currentCount = 0; // Текущее количество
        int previousNumber = -1; // Предыдущее число (инициализация значением вне натуральных чисел)

        Console.WriteLine("Введите последовательность натуральных чисел, завершающуюся 0:");

        while (true)
        {
            int number;
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число.");
                continue;
            }

            if (number == 0) break; // Выход из цикла при вводе 0

            if (previousNumber == -1) // Первый элемент последовательности
            {
                previousNumber = number;
                currentCount = 1;
                maxCount = 1;
            }
            else
            {
                if (number == previousNumber)
                {
                    currentCount++;
                }
                else
                {
                    // Обновляем максимум при смене числа
                    if (currentCount > maxCount) maxCount = currentCount;
                    previousNumber = number;
                    currentCount = 1;
                }

                // Проверка максимума после каждого изменения currentCount
                if (currentCount > maxCount) maxCount = currentCount;
            }
        }

        // Проверка последней последовательности после окончания ввода
        if (currentCount > maxCount) maxCount = currentCount;

        Console.WriteLine($"Наибольшее число подряд идущих одинаковых элементов: {maxCount}");
    }
}
