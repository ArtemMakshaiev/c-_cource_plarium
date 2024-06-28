using static System.Net.Mime.MediaTypeNames;

namespace HW5_Task3_Currency_Converter
{
    internal class Program
    {
        //        Завдання 3
        //Використовуючи Visual Studio, створіть проєкт за шаблоном Console Application.
        //Напишіть програму, яка буде виконувати конвертування валют.
        //Користувач вводити:
        //      - суму грошей в певній валюті.
        //      - курс для конвертації в іншу валюту.
        //Організуйте виведення результату операції конвертації валюти на екран.
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введіть суму грошей в валюті яку потрібно конвертувати: ");
            double currencyAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть курс обміну за яким відбудеться конвертація в іншу валюту: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            double convertedAmount = ConvertCurrency(currencyAmount, rate);

            Console.WriteLine($"Результат конвертації: {convertedAmount}");

            Console.ReadLine();
        }

        static double ConvertCurrency(double currencyAmount, double rate)
        {
            return currencyAmount * rate;
        }
    }
}
