using System;

class Program
{
    static int NOD(int a, int b)
    {
        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }

        return a;
    }

    static int NOD(int a, int b, int c)
    {
        return NOD(NOD(a, b), c);
    }

    static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Введите третье число: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("НОД двух чисел = " + NOD(a, b));
        Console.WriteLine("НОД трех чисел = " + NOD(a, b, c));
    }
}

