using System.ComponentModel.DataAnnotations;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int r;
            Console.WriteLine("Для розрахкнку площі кола введіть довжину радіуса");
            r = int.Parse(Console.ReadLine());

            Console.WriteLine("Площа круга = " + Math.PI * Math.Pow(r, 2));

            Console.ReadKey();
        }
    }
}
