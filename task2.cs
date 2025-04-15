using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        
        for (int i = 2; i * i <= N; i++)
        {
            if (N % i == 0)
            {
                Console.WriteLine(i);
                return;
            }
        }
        
        // Если делитель не найден, то N - простое число
        Console.WriteLine(N);
    }
}
