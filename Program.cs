using System;

class Program
{
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        Console.WriteLine("Упражнение 5.2. Обмен значениями");

        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("До обмена: a = " + a + ", b = " + b);

        Swap(ref a, ref b);

        Console.WriteLine("После обмена: a = " + a + ", b = " + b);
    }
}

