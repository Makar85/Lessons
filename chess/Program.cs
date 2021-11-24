using System;

/*
 Напишите программу, которая определяет корректность хода ферзя, заданного в шахматной нотации, 
 например “e2-f4” – некорректный, а “c2-c3”, “c2-e2”, “c2-f5” – корректные ходы.
 */

namespace chess
{
    class Program
    {
        static bool Queenmove(string notation)
        {
            string[] cells = notation.Split("-");
            char[] srcCell = cells[0].ToCharArray();
            char[] dstCell = cells[1].ToCharArray();

            int deltaX = Math.Abs(srcCell[0] - dstCell[0]);
            int deltaY = Math.Abs(srcCell[1] - dstCell[1]);

            if (deltaX == 0 && deltaY == 0)
                return false;
            if (deltaX == deltaY)
                return true;
            if (deltaX == 0 ^ deltaY == 0)
                return true;
            else
                return false;

        }
        static void Main(string[] args)
        {
            Console.Write("Enter step: ");
            string step = Console.ReadLine();
            bool result = CheckStep(step);
            if (result == true)
                Console.WriteLine("Allowed");
            else
                Console.WriteLine("Denied");
        }
    }
}
