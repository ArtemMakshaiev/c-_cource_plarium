using System.Drawing;

namespace HW4_Task_3_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        Завдання 3
            //Використовуючи Visual Studio, створіть проєкт за шаблоном Console Application.
            //Використовуючи цикли і метод :
            //Console.Write("*"), Console.Write(""), Console.Write("\n")(для переходу на новий рядок).
            //Виведіть на екран:
            //    - прямокутник
            //    - прямокутний трикутник
            //    - рівносторонній трикутник
            //    - ромб

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Малюємо прямокутник");
            Console.Write("\n");

            Random rand = new Random();

            int heihgt = rand.Next(8, 20);
            int width = rand.Next(5, 15);

            for (int i = 0; i < heihgt; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Write("\n");

            Console.WriteLine("Малюємо прямокутний трикутник");
            Console.Write("\n");

            int triangleSize = 8;

            for (int i = 1; i <= triangleSize; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            Console.WriteLine("Малюємо рівносторонній трикутник");
            Console.Write("\n");

            int eqTriangleSize = 7;

            for (int i = 1; i <= eqTriangleSize; i++)
            {
                for (int j = eqTriangleSize - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            Console.WriteLine("Малюємо ромб");
            Console.Write("\n");

            int rhombusSize = 5;

            for (int i = 1; i <= rhombusSize; i++)
            {
                for (int j = rhombusSize - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (int i = rhombusSize - 1; i > 0; i--)
            {
                for (int j = 0; j < rhombusSize - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < 2 * i; k++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

        }
    }
}
