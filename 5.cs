using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите размерность матриц");
                int n = Convert.ToInt32(Console.ReadLine());

                int[] m1 = new int[n * n];
                int[] m2 = new int[n * n];
                int[] m3 = new int[n * n];
                int a = 0;

                Random rnd = new Random();

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < n; j++)
                    {
                        int value = rnd.Next(10);
                        m1[a] = value;
                        Console.Write($"{m1[a]}\t");
                        a++;
                    }
                }
                a = 0;

                Console.WriteLine('\n');
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < n; j++)
                    {
                        int value = rnd.Next(10);
                        m2[a] = value;
                        Console.Write($"{m2[a]}\t");
                        a++;
                    }
                }
                a = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            m3[i * n + j] += m1[i * n + k] * m2[k * n + j];

                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine("\nМатрица после умножения");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{m3[a]}\t");
                        a++;
                    }
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Неверный формат ввода");
            }
            catch
            {
                Console.WriteLine("Неопознанное исключение");
            }
        }
    }
}
