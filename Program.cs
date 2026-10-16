using System;

class Program
{
    static int Max(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    static void Main()
    {
        Console.WriteLine("Упражнение 5.1. Наибольшее из двух чисел");

        Console.Write("Введите первое целое число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите второе целое число: ");
        int b = int.Parse(Console.ReadLine());

        int result = Max(a, b);

        Console.WriteLine("Наибольшее число: " + result);
    }
}

