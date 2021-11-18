using System;

namespace HW1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите конечное число диапазона:");
            int range = int.Parse(Console.ReadLine());

            
            for (int i = 2; i < range; i++)
            {
                bool isPrimeNum = true;

                for (int k = 2; k < i; k++)
                {
                    if (i%k==0)
                    {
                        isPrimeNum = false;
                        break;
                    }

                }

                if (isPrimeNum)
                {
                    Console.WriteLine(i);
                }
      
            }


            


          
            


        }
    }
}
