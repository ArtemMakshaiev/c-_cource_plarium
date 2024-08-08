using static System.Net.Mime.MediaTypeNames;

        //        Завдання 2
        //Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        //Потрібно: Створити клас з ім'ям Rectangle.
        //У тілі класу створити два поля, що описують довжини сторін double side1, side2.
        //Створити користувальницький конструктор Rectangle (double side1, double side2), в тілі якого поля side1 і
        //side2 инициализируются значеннями аргументів.
        //Створити два методи, що обчислюють площу прямокутника - double AreaCalculator () і периметр
        //прямокутника - double PerimeterCalculator ().
        //Створити дві властивості double Area і double Perimeter з одним методом доступу get.
        //Написати програму, яка приймає від користувача довжини двох сторін прямокутника і виводить на екран
        //периметр і площу.

namespace HW7_Task2_RectangleClass
{
    class Rectangle
    {
        // Поля, що описують довжини сторін
        private double side1;
        private double side2;

        // Користувальницький конструктор Rectangle
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        // Метод, що обчислюює площу прямокутника
        public double AreaCalculator()
        {
            return side1 * side2;
        }

        // Метод, що обчислюює периметр прямокутника
        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }

        // Властивость для отримання Area
        public double Area
        {
            get { return AreaCalculator(); }
        }

        // Властивость для отримання Perimeter
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Підкаска користувачеві
            Console.WriteLine("Введіть довжину строни 1:");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть довжину строни 2:");
            double side2 = Convert.ToDouble(Console.ReadLine());

            // Створення нового об'єкту Rectangle
            Rectangle rectangle = new Rectangle(side1, side2);

            // Виведення на екран площи та периметру прямокутника
            Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
            Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");

            Console.WriteLine("Натисніть будь яку кливишу для виходу із програми...");
            Console.ReadKey();
        }
    }
}
