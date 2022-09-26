using System;

namespace Schastliviy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число и нажмите клавишу Enter: ");

            string number = Console.ReadLine();
            int num = Convert.ToInt32(number);

            if (num.ToString().Length == 6)
            {
                int number1 = num / 100000;
                int number2 = (num / 10000) % 10;
                int number3 = (num / 1000) % 10 % 10;
                int number4 = (num / 100) % 10 % 10 % 10;
                int number5 = (num / 10) % 10 % 10 % 10 % 10;
                int number6 = num % 10 % 10 % 10 % 10;

                if (number1 + number2 + number3 == number4 + number5 + number6)
                {
                    Console.WriteLine("Билет счастливый");
                }
                else
                {
                    Console.WriteLine("Билет несчастливый");
                }
            }
            else
            {
                Console.WriteLine("Введите шестизначное число");
            }

            Console.Write("Введите первое число и нажмите клавишу Enter: ");
            string numa = Console.ReadLine();
            Console.Write("Введите Второе число и нажмите клавишу Enter: ");
            string numb = Console.ReadLine();

            int a = Convert.ToInt32(numa);
            int b = Convert.ToInt32(numb);

            int result = 0;

            while (a > 0)
            {
                if ((a & 1) > 0) result += b;

                b <<= 1;
                a >>= 1;
            }

            Console.WriteLine(result);

            Console.WriteLine("Полная запись десятичного числа : 42?4?");

            int res = 0;

            for (int i = 0; i <=9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    if (((42040 + (100 * i) + j) % 72) == 0)
                    {
                        res = 42040 + (100 * i) + j;
                        Console.WriteLine($"Полная запись десятичного числа : {res} ");
                    }
                }
            }

            Console.WriteLine("Трехзначные числа, средняя цифра которых равна сумме первой и второй цифр");

            for (int i = 100; i <=999; i++)
            {
                if (i / 10 % 10 == i / 100 + i % 10) ;

                Console.WriteLine($"Трехзначное число, средняя цифра которого равна сумме первой и второй цифр : {i}");
            }


            Console.WriteLine("Двузначные числа удвоенная сумма цифр равна их произведению");
            for (int i = 1; i <= 9; ++i)
            {
                for (int j = 0; j <= 9; ++j)
                {
                    if (2 * (i + j) == i * j)
                    {
                        int r = 10 * i + j;
                        Console.WriteLine($"Число {r}");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
