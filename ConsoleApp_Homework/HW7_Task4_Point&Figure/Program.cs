using System;
using System.Text;

namespace HW7_Task4_Point_Figure
{
    public class Point
    {
        private int x;
        private int y;
        private string name;

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }

        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }

    public class Figure
    {
        private Point[] points;

        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[] { p1, p2, p3 };
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[] { p1, p2, p3, p4 };
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[] { p1, p2, p3, p4, p5 };
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public double PerimeterCalculator()
        {
            double perimeter = 0.0;

            for (int i = 0; i < points.Length; i++)
            {
                perimeter += LengthSide(points[i], points[(i + 1) % points.Length]);
            }

            return perimeter;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Створюємо поінти
            Point point1 = new Point(2, 0, "Point A");
            Point point2 = new Point(5, 0, "Point B");
            Point point3 = new Point(3, 6, "Point C");
            Point point4 = new Point(1, 4, "Point D");

            // Створюємо фігуру
            Figure rectangle = new Figure(point1, point2, point3, point4);

            // Розраховуємо периметр
            double perimeter = rectangle.PerimeterCalculator();

            // Відображаємо результат
            Console.WriteLine($"Периметр багатокутника складає: {perimeter}");
            Console.ReadLine();
        }
    }

}
