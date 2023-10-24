using System;
using System.Collections.Generic;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int c = 0;
                int N, M;
                int[] A1, A2;

                Console.WriteLine("Количество элементов 1 массива");
                N = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Количество элементов 2 массива");
                M = Convert.ToInt32(Console.ReadLine());
                A1 = new int[N];
                A2 = new int[M];

                List<int> list = new List<int>();
                Random rnd = new Random();


                while (c != 8)
                    {
                    Console.WriteLine();
                    Console.WriteLine("Выберите номер операции");
                    Console.WriteLine("1 - инициализация массивов");
                    Console.WriteLine("2 - поэлементное сложение в случае равенства длин");
                    Console.WriteLine("3 - умножение 1 массива на константу");
                    Console.WriteLine("4 - поиск общих значений массивов");
                    Console.WriteLine("5 - печать массивов");
                    Console.WriteLine("6 - упорядочивание значений 1 массива по убыванию");
                    Console.WriteLine("7 - поиск минимума, максимума, среднего значения в 1 массиве");
                    Console.WriteLine("8 - выход");
                    c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    switch (c)
                    {
                        case 1:
                            {
                                A1 = inizialization(N);
                                A2 = inizialization(M);
                                break;
                            }
                        case 2:
                            {
                                if (N == M)
                                {
                                    for (int i = 0; i < N; i++)
                                    {
                                        Console.WriteLine(sum(A1[i], A2[i]));
                                    }
                                }
                                else
                                    Console.WriteLine("Длины массивов не одинаковые");
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Введите множитель");
                                int k = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                for (int i = 0; i < N; i++)
                                {
                                    Console.WriteLine(multiplicate(A1[i], k));
                                }
                                break;
                            }
                        case 4:
                            {
                                var num = new List<int>();
                                num = same(A1, A2, N, M);
                                foreach (var p in num)
                                {
                                    Console.WriteLine(p);
                                }
                                break;
                            }
                        case 5:
                            {
                                print(A1, N);
                                Console.WriteLine();
                                print(A2, M);
                                break;
                            }
                        case 6:
                            {
                                int[] ar = raise(A1, N);
                                foreach (var p in ar)
                                {
                                    Console.WriteLine(p);
                                }
                                break;
                            }
                        case 7:
                            {
                                Console.WriteLine("Максимум");
                                Console.WriteLine(extr(A1, N, 1));
                                Console.WriteLine("Минимум");
                                Console.WriteLine(extr(A1, N, 2));
                                Console.WriteLine("Среднее значение");
                                Console.WriteLine(extr(A1, N, 3));
                                break;
                            }
                        case 8:
                            break;
                    }
                }

                int[] inizialization(int n)
                {
                    int[] a = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        int value = rnd.Next(100);
                        a[i] = value;
                    }
                    return a;
                }

                int sum(int s1, int s2)
                {
                    return s1 + s2;
                }

                long multiplicate(int p1, int p2)
                {
                    return p1 * p2;
                }

                static List<int> same(int[] ar1, int[] ar2, int n, int m)
                {
                    var nums = new List<int>();
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            if (ar1[i] == ar2[j])
                                if (!nums.Contains(ar1[i]))
                                    nums.Add(ar1[i]);
                        }
                    }
                    return nums;
                }

                void print(int[] a, int n)
                {
                    for (int i = 0; i < n; i++)
                        Console.WriteLine(a[i]);
                }

                static int[] raise(int[] a, int n)
                {
                    int t;
                    for (int i = 0; i < n; i++)
                        for (int j = 0; j < n - 1 - i; j++)
                            if (a[j] < a[j + 1])
                            {
                                t = a[j];
                                a[j] = a[j + 1];
                                a[j + 1] = t;
                            }
                    return a;
                }

                int extr(int[] a, int n, int m)
                {
                    int min = 1000;
                    int max = 0;
                    int average = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (a[i] > max)
                            max = a[i];
                        if (a[i] < min)
                            min = a[i];
                        average += a[i];
                    }
                    average /= n;
                    if (m == 1)
                        return max;
                    if (m == 2)
                        return min;
                    else
                        return (average);
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
