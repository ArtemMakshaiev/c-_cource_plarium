namespace HW4_Task_4_Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        Завдання 4
            //Є N клієнтів, яким компанія-виробник повинна доставити товар.Скільки існує можливих маршрутів
            //доставки товару з урахуванням того, що товар буде доставляти одна машина?
            //Використовуючи Visual Studio, створіть проєкт за шаблоном Console Application.
            //Напишіть програму, яка буде розраховувати і виводити на екран кількість можливих варіантів доставки
            //товару.Для вирішення завдання використовуйте факторіал N!, що розраховується за допомогою
            //циклу do - while.

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Ввкдіть кільуість клієнтів (N):");
            int N = int.Parse(Console.ReadLine());

            int factorial = 1;
            int i = 1;

            do
            {
                factorial *= i;
                i++;
            } while (i <= N);

            Console.WriteLine($"кількість можливих варіантів доставки товару для {N} клієнтів: {factorial}");

        }
    }
}
