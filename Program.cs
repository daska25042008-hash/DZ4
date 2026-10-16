using System;

class Program
{
    static int Fibonacci(int n)
    {
        if (n == 1 || n == 2)
        {
            return 1;
        }

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        Console.Write("Введите номер числа Фибоначчи: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Число Фибоначчи: " + Fibonacci(n));
    }
}

