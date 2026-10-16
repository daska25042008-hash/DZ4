using System;
using System.Threading;

enum GrumpLevel
{
    Calm,
    Grumpy,
    Angry
}

struct Ded
{
    public string Name;
    public GrumpLevel Level;
    public string[] Phrases;
    public int Bruises;

    public Ded(string name, GrumpLevel level, string[] phrases)
    {
        Name = name;
        Level = level;
        Phrases = phrases;
        Bruises = 0;
    }
    public static int CheckDed(Ded ded, params string[] badWords)
    {
        int count = 0;

        foreach (string phrase in ded.Phrases)
        {
            foreach (string word in badWords)
            {
                if (phrase.Contains(word, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }
        }

        return count;
    }
}

class Program
{
    static int Sum(params int[] nums)
    {
        int sum = 0;

        foreach (int num in nums)
        {
            sum += num;
        }

        return sum;
    }
    static void Product(int[] nums, ref long product)
    {
        product = 1;

        foreach (int num in nums)
        {
            product *= num;
        }
    }
    static void Average(int[] nums, out double average)
    {
        average = 0;

        foreach (int num in nums)
        {
            average += num;
        }

        average /= nums.Length;
    }
    static void DrawDigit(int num)
    {
        string[] lines = num switch
        {
            0 => new string[] { " ### ", "#   #", "#   #", "#   #", " ### " },
            1 => new string[] { "  #  ", " ##  ", "  #  ", "  #  ", " ### " },
            2 => new string[] { " ### ", "#   #", "   # ", "  #  ", "#####" },
            3 => new string[] { "#### ", "    #", " ### ", "    #", "#### " },
            4 => new string[] { "#   #", "#   #", "#####", "    #", "    #" },
            5 => new string[] { "#####", "#    ", "#### ", "    #", "#### " },
            6 => new string[] { " ### ", "#    ", "#### ", "#   #", " ### " },
            7 => new string[] { "#####", "    #", "   # ", "  #  ", "  #  " },
            8 => new string[] { " ### ", "#   #", " ### ", "#   #", " ### " },
            9 => new string[] { " ### ", "#   #", " ####", "    #", " ### " },
            _ => new string[0]
        };
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
    static void Task1()
    {
        Console.WriteLine("\nЗАДАНИЕ 1. Массив и обмен чисел");
        Console.WriteLine("Программа создаст 20 случайных чисел.");
        Console.WriteLine("Введите два числа из массива для обмена местами.");

        int[] nums = new int[20];
        Random random = new Random();

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = random.Next(1, 101);
        }

        Console.WriteLine("Исходный массив:");
        Console.WriteLine(string.Join(" ", nums));

        Console.Write("Первое число: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Второе число: ");
        int second = int.Parse(Console.ReadLine());

        int index1 = Array.IndexOf(nums, first);
        int index2 = Array.IndexOf(nums, second);

        if (index1 == -1 || index2 == -1)
        {
            Console.WriteLine("Ошибка! Одного из чисел нет в массиве.");
        }
        else
        {
            int temp = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = temp;

            Console.WriteLine("Массив после обмена:");
            Console.WriteLine(string.Join(" ", nums));
        }
    }
    static void Task2()
    {
        Console.WriteLine("\nЗАДАНИЕ 2. params, ref и out");
        Console.WriteLine("Программа вычислит сумму, произведение и среднее.");

        int[] nums = { 2, 3, 4, 5 };

        Console.WriteLine("Массив: " + string.Join(" ", nums));

        int sum = Sum(nums);
        Console.WriteLine("Сумма: " + sum);

        long product = 0;
        Product(nums, ref product);
        Console.WriteLine("Произведение: " + product);

        double average;
        Average(nums, out average);
        Console.WriteLine("Среднее арифметическое: " + average);
    }
    static void Task3()
    {
        Console.WriteLine("\nЗАДАНИЕ 3. Рисунок цифр");
        Console.WriteLine("Введите число от 0 до 9.");
        Console.WriteLine("Для завершения введите exit или закрыть.");

        while (true)
        {
            Console.Write("\nВаш ввод: ");
            string input = Console.ReadLine();

            if (input == "exit" || input == "закрыть")
            {
                Console.WriteLine("Работа с цифрами завершена.");
                break;
            }
            int num = int.Parse(input);

            if (num < 0 || num > 9)
            {
                ConsoleColor oldColor = Console.BackgroundColor;

                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("ОШИБКА! Нужно ввести число от 0 до 9.");

                Thread.Sleep(3000);

                Console.BackgroundColor = oldColor;
                Console.Clear();
            }
            else
            {
                DrawDigit(num);
            }
        }
    }
    static void Task4()
    {
        Console.WriteLine("\nЗАДАНИЕ 4. Деды и фингалы");
        Console.WriteLine("Проверяем лексику пяти дедов.");

        Ded[] deds =
        {
            new Ded("Петр", GrumpLevel.Calm, new string[]
            {
                "Опять дождь!", "Чай остыл!"
            }),

            new Ded("Иван", GrumpLevel.Grumpy, new string[]
            {
                "Вот же черт!", "Опять суета!",
                "Ничего нормально сделать нельзя!"
            }),

            new Ded("Семен", GrumpLevel.Angry, new string[]
            {
                "Опять сломалось!",
                "Вот же черт!",
                "Беспредел какой-то!",
                "Опять бардак!"
            }),

            new Ded("Борис", GrumpLevel.Grumpy, new string[]
            {
                "Блин, где мои очки?",
                "Опять шумят!"
            }),

            new Ded("Николай", GrumpLevel.Angry, new string[]
            {
                "Сука, опять опоздали!",
                "Черт побери!",
                "Опять бардак!",
                "Блин, ну что за день!",
                "Ничего без меня не могут!"
            })
        };

        string[] badWords = {"черт", "блин" };

        foreach (Ded ded in deds)
        {
            int bruises = Ded.CheckDed(ded, badWords);

            Console.WriteLine("\nДед: " + ded.Name);
            Console.WriteLine("Уровень ворчливости: " + ded.Level);
            Console.WriteLine("Количество фраз: " + ded.Phrases.Length);
            Console.WriteLine("Фингалов от бабки: " + bruises);
        }
    }

    static void Main()
    {
        Task1();
        Task2();
        Task4();
        Task3();
    }
}

