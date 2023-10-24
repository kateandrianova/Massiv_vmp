using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите размер изначального массива");
                int N = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите размер нового массива");
                int M = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите позицию");
                int k = Convert.ToInt32(Console.ReadLine());

                int[] nums = new int[N];
                int[] new_nums = new int[M];
                int[] result = new int[M + N];
                int value, j = 0, b = k;

                Random rnd = new Random();

                Console.WriteLine("Исходный массив",'\n');
                for (int i = 0; i < N; i ++)
                {
                    value = rnd.Next();
                    nums[i] = value;
                    Console.WriteLine(nums[i]);
                }

                Console.WriteLine("Новый массив", '\n');
                for (int i = 0; i < M; i++)
                {
                    value = rnd.Next();
                    new_nums[i] = value;
                    Console.WriteLine(new_nums[i]);
                }

                Console.WriteLine();
                for (int i = 0; i < k; i++)
                {
                    result[i] = nums[i];
                    Console.WriteLine(result[i]);
                }
                for (int i = 0; i < M; i++)
                {
                    result[k] = new_nums[i];
                    Console.WriteLine(result[k]);
                    k++;
                }
                for (int i = b; i < N; i++)
                {
                    result[k] = nums[i];
                    Console.WriteLine(result[k]);
                    k++;
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
