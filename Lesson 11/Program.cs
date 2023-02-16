using System;

namespace Lesson_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Программа1            

                Console.WriteLine("Программа1");

                Console.WriteLine("Введите число 'A':");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число 'B':");
                int B = Convert.ToInt32(Console.ReadLine());

                int A0 = A;

                if (B == 0)
                {
                    Console.WriteLine("Число A в степени B равно " + 1 + ".");
                }
                else
                {
                    for (int i = 1; i < B; i++)
                    {
                        A = A0 * A;
                    }
                    Console.WriteLine("Число A в степени B равно " + A + ".");
                }

                Console.ReadLine();



                // Программа2

                Console.WriteLine("Программа2");

                Console.WriteLine("Введите число:");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.Write("Все числа от 1 до 1000, которые делятся на введённое число: ");

                for (int i = number; i <= 1000; i += number)
                {
                    Console.Write(i + "," + " ");
                }
                Console.WriteLine(".");
                Console.ReadLine();



                // Программа3

                Console.WriteLine("Программа3");

                Console.WriteLine("Введите число:");
                int N = Convert.ToInt32(Console.ReadLine());
                int Z = 0;

                for (int i = 1; i < N; i++)
                {
                    if (i * i < N)
                    {
                        Z++;
                    }
                }
                Console.WriteLine("Количество положительных целых чисел, квадрат которых меньше введённого числа: " + Z + ".");
                Console.ReadLine();



                // Программа4

                Console.WriteLine("Программа4");

                Console.WriteLine("Введите число 'A':");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число 'B':");
                int b = Convert.ToInt32(Console.ReadLine());

                int sum = 0;

                if (a == b)
                {
                    Console.WriteLine("Введите разные числа.");
                }

                else
                {
                    if ((b - a) < 7)
                    {
                        Console.WriteLine("Введите другие числа.");
                    }
                    else
                    {
                        for (int i = a; i <= b; i++)
                        {
                            if (i % 7 == 0)
                                sum += i;
                        }
                        Console.WriteLine("Сумма всех чисел, которые делятся на 7, из диапазона от A до B равна" + " " + sum + ".");
                    }
                }
                Console.ReadLine();



                // Программа5

                Console.WriteLine("Программа4");

                Console.WriteLine("Введите положительное число 'N':");
                int Np = Convert.ToInt32(Console.ReadLine());

                int fb1 = 1;

                int fb2 = 1;

                int valueFb = 0;

                if (Np < 0)
                {
                    Console.WriteLine("Введите положительное число!");
                }
                else
                {
                    if (Np == 1 || Np == 2)
                    {
                        Console.WriteLine("N-ое число ряда Фибоначчи: " + 1 + ".");
                    }
                    else
                    {
                        for (int i = 2; i < Np; i++)
                        {
                            valueFb = fb1 + fb2;
                            fb1 = fb2;
                            fb2 = valueFb;
                        }
                        Console.WriteLine("N-ое число ряда Фибоначчи: " + valueFb + ".");
                    }
                }
                Console.WriteLine("Конец!");
                Console.ReadLine();
            }

        }
    }
}
