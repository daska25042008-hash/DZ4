using System;

class Program
{
    static long FactorialRecursive(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Число не может быть отрицательным.");
        }

        if (n == 0 || n == 1)
        {
            return 1;
        }

        return checked(n * FactorialRecursive(n - 1));
    }

    static void Main()
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());

        try
        {
            long result = FactorialRecursive(n);
            Console.WriteLine("Факториал равен: " + result);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Ошибка: число слишком большое.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

