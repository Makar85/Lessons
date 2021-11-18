using System;


//Напишите программу, позволяющую вывести все простые числа в диапазоне до заданного.

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите конец диапазона от 2 до : ");
            int range = int.Parse(Console.ReadLine());
            for (int i = 2; i <= range; i++)
            {
                if (isSimple(i))
                {
                    Console.Write(i.ToString() + "\n");
                }
            }
        }
        //метод который определяет простое число или нет
        private static bool isSimple(int N)
        {
            //чтоб убедится простое число или нет достаточно проверить не делитсья ли 
            //число на числа до его половины
            for (int i = 2; i < (int)(N / 2); i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;



        }
    }
}
