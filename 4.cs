using System;
using System.Linq;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число рядов");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число мест в ряду");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите количество мест");
                int k = Convert.ToInt32(Console.ReadLine());

                int[,] arr = new int[n, m];
                int count = 0;
                bool flag = false;

                Console.WriteLine("Вводите строки");
                for (int i = 0; i < n; i++)
                {
                    string s = Console.ReadLine();
                    var items = s.Split(new char[] { ' ' });
                    for (int j = 0; j < m; j++)
                    {
                        arr[i, j] = int.Parse(items[j]);
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    if (flag == false)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            if (arr[i, j] == 0)
                                count++;
                            else
                                count = 0;
                            if (count == k)
                            {
                                Console.WriteLine(i + 1);
                                flag = true;
                            }
                        }
                        count = 0;
                    }
                    else
                        break;
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
