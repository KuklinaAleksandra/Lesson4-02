using System;

namespace Lesson4_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите числа для суммирования через пробел");
            Console.WriteLine(GetSum(Console.ReadLine()));
            Console.WriteLine();

        }

        static int GetSum(string inputline)
        {
            int sum = 0;
            string numbers = " ";
            for (int i = 0; i <= inputline.Length; i++)
            {
                if (i == inputline.Length || inputline[i] == ' ')
                {
                    if (numbers != "")
                    {
                        sum += Convert.ToInt32(numbers);
                        numbers = "";
                    }
                }
                else
                {
                    numbers += inputline[i];
                }
            }
            return sum;
        }
    }
}
