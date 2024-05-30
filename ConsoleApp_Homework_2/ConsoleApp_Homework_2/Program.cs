namespace ConsoleApp_Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int x = 10, y = 12, z = 3;

            //int result1 = (x + = y - x++ * z);
            //Console.WriteLine("1. Результат виразу x + = y - x ++ * z дорівнює " + result1);

            int result2 = (z = --x - y * 5);
            Console.WriteLine("2. Результат виразу z = --x - y * 5 дорівнює " + result2);

            //int result3 = (y / = x + 5 % z);
            //Console.WriteLine("3. Результат виразу y / = x + 5 % z дорівнює " + result3);

            int result4 = (z = x ++ + y * 5);
            Console.WriteLine("4. Результат виразу z = x ++ + y * 5 дорівнює " + result4);

            int result5 = (x = y - x++ * z);
            Console.WriteLine("5. Результат виразу x = y - x ++ * z дорівнює " + result5);

            Console.ReadKey();
        }
    }
}
