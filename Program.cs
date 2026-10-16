using System;

class Program
{
    static bool Factorial(int n, out long result)
    {
        result = 1;

        if (n < 0)
        {
            return false;
        }

        try
        {
            checked
            {
                for (int i = 1; i <= n; i++)
                {
                    result = result * i;
                }
            }

            return true;
        }
        catch (OverflowException)
        {
            result = 0;
            return false;
        }
    }

    static void Main()
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());

        bool success = Factorial(n, out long result);

        if (success)
        {
            Console.WriteLine("Факториал равен: " + result);
        }
        else
        {
            Console.WriteLine("Не удалось вычислить факториал.");
        }
    }
}
