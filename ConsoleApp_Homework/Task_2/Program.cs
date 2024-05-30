namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            decimal x = 10, y = 12, z = 3;

            decimal result = ((x+y+z)/3);
            Console.WriteLine("Середня арифметична чисел 10, 12 та 3 дорівнює " + result);

            Console.ReadKey();
        }
    }
}
