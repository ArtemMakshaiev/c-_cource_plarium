namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double r, h, s, v;
            r = h = 1.0;
            Console.Write("Введіть радіус циліндра R: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть высоту циліндра H: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("---");
            v = Math.PI * r * r * h;
            s = 2 * Math.PI * r * h;
            Console.WriteLine("Площа поверхні цилиндра = {0}, Об'єм циліндра = {1}\n", s, v);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
