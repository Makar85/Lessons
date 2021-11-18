using System;

namespace HW1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите конец диапазона от 2 до : ");
            int end = int.Parse(Console.ReadLine());
            for (int i = 2; i <= end; i++)
            {
                bool b = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        b = false;
                    }
                }
                if (b)
                {
                    Console.Write("{0} ", i);
                }
            }

        }
    }
}
