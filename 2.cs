using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите размер массива");
                int N = Convert.ToInt32(Console.ReadLine());
                int[] nums = new int[N];

                Random rnd = new Random();

                Console.WriteLine("Массив");
                for (int i = 0; i < N; i++)
                {
                    int value = rnd.Next(100);
                    nums[i] = value;
                    Console.WriteLine(nums[i]);
                }
                
                Console.WriteLine("Массив после смены");
                
                for (int i = 0; i < N / 2; i++)
                {
                    int t = nums[i];
                    int c = i + N / 2;
                    nums[i] = nums[c];
                    nums[c] = t;
                }
                if (N % 2 == 1)
                {
                    for (int i = 1; i < N / 2 + 1; i++)
                    {
                        int b = nums[N - i];
                        nums[N - i] = nums[N - i - 1];
                        nums[N - i - 1] = b;
                    }
                }

                for (int i = 0; i < N; i++)
                {                    
                    Console.WriteLine(nums[i]);
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
