using System;

/*
 «Волшебные» даты – это даты, в которых при перемножении порядковых чисел дня и месяца можно 
получить двухзначный номер года. Например, 10 июня 1960 года – волшебная дата, 
т. к. 10*6 = 60. Составить программу, выводящую на экран все «волшебные даты» 21 века.
 */

namespace MagicDates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] leapYears = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] ordinaryYears = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            for (int year = 0; year < 100; year++)
            {
                int[] daysInMonth = ordinaryYears;
                if (year % 4 == 0 && year != 0)
                {
                    daysInMonth = leapYears;
                }
                for (int month = 1; month < 13; month++)
                {
                    for (int day = 1; day < daysInMonth[month - 1]; day++)
                    {
                        if (month * day == year)
                        {
                            string strYear = year < 10 ? $"0{year}" : year.ToString();
                            Console.WriteLine($"Magical day: {day}.{month}.20{strYear}");
                        }
                    }
                }
            }
        }
    }
}
