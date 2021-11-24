using System;
using System.Collections.Generic;

/*Напишите программу вычисления площади пятиугольника. Исходными данными являются координаты вершин. 
 * Для решения задачи следует использовать метод декомпозиции: сначала получить площадь треугольников,
 * а их затем сложить.
 * Для расчета длины стороны и площади треугольника рекомендуется использовать отдельные функции*/

namespace HW3._1
{
    class Program
    {
        static double totalArea;

        static void Main(string[] args)
        {
            Point[] points = new Point[5];
            points[0] = GetPointFromUser("A");
            points[1] = GetPointFromUser("B");
            points[2] = GetPointFromUser("C");
            points[3] = GetPointFromUser("D");
            points[4] = GetPointFromUser("E");

            double AB = CalcLineLength(points[0], points[1]);
            double BC = CalcLineLength(points[1], points[2]);
            double AC = CalcLineLength(points[0], points[2]);
            double DC = CalcLineLength(points[3], points[2]);
            double AD = CalcLineLength(points[0], points[3]);
            double DE = CalcLineLength(points[3], points[4]);
            double AE = CalcLineLength(points[0], points[4]);

            

            double ABC = CalcTriangleArea(AB, BC, AC);
            double ACD = CalcTriangleArea(AD, DC, AC);
            double ADE = CalcTriangleArea(AD, DE, AE);
            
            //считаем площадь пятиугольника, путем сложения треугольников
            totalArea = ABC + ACD + ADE;
            Console.WriteLine($"Area of pentagon is {totalArea}");

            Console.Read();
        }

        double GetTotalArea()
        {
            return totalArea;
        }

        static double CalcTriangleArea(double side1, double side2, double side3)
        {
            // Формула Герона
            double p = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(p*(p-side1)*(p-side2)*(p-side3)); 
            return area;
        }

        static double CalcLineLength(Point point1, Point point2)
        {
            // Distance between points.
            double sqrX = Math.Pow(point1.X - point2.X, 2);
            double sqrY = Math.Pow(point1.Y - point2.Y, 2);
            double sideLength = Math.Sqrt(sqrX + sqrY);
            return sideLength;
        }

        static Point GetPointFromUser(string pointName)
        {
            Console.WriteLine($"Enter coordinates of point {pointName}");
            Point point = new Point();
            var o = new object();
            string[] inputs = Console.ReadLine().Split(',');
            point.X = double.Parse(inputs[0]);
            point.Y = double.Parse(inputs[1]);
            Console.WriteLine($"Distance from (0;0) is {point.DistanceFromZeroPoint}");
            return point;
        }
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public double DistanceFromZeroPoint
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }

        //public double GetX()
        //{
        //  return x;
        //}

        //public void SetX(double x)
        //{
        //  this.x = x;
        //}
    }
}