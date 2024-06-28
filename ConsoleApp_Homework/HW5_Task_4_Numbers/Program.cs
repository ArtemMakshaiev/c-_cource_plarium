using static System.Net.Mime.MediaTypeNames;

namespace HW5_Task_4_Numbers
{
    internal class Program
    {
        //        Завдання 4
        //Використовуючи Visual Studio, створіть проєкт за шаблоном Console Application.
        //Напишіть метод, який буде визначати:
        //1) Чи є введене число позитивним або негативним.
        //2) Чи є воно простим(використовуйте техніку перебору значень).
        //(Просте число - це натуральне число, яке ділиться на 1 і саме на себе.Щоб визначити просте число, чи
        //ні, слід знайти всі його цілі дільники. Якщо дільників більше 2 -х, значить воно не просте)
        //3) Чи ділиться на 2, 5, 3, 6, 9 без залишку.
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введіть число для дослідження: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"1) Введене число {numberSign(num)}");

            Console.WriteLine($"2) Введене число {(isPrime(num) ? "просте" : "не просте")}");

            Console.WriteLine($"3) Введене число {(IsDivisibleBy23569(num) ? "" : "не ")}ділиться на 2, 5, 3, 6, 9 без залишку");

            Console.ReadLine();
        }

        static string numberSign(int num)
        {
            if (num > 0)
                return "позитивне";
            else if (num < 0)
                return "негативне";
            else
                return "нуль";
        }

        static bool isPrime(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        static bool IsDivisibleBy23569(int num)
        {
            return num % 2 == 0 && num % 3 == 0 && num % 5 == 0 && num % 6 == 0 && num % 9 == 0;
        }
    }
}
