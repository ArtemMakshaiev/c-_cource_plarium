using static System.Net.Mime.MediaTypeNames;
using System;

namespace HW8_Task2_Converter

    //Завдання 2
    //Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    //Потрібно:
    //Створити клас Converter.
    //У тілі класу створити користувальницький конструктор, який приймає три речових аргументу, і ініціалізує
    //поля відповідні курсу 3-х основних валют, по відношенню до гривні - public Converter(double usd, double
    //eur, double rub).
    //Написати програму, яка буде виконувати конвертацію з гривні в одну із зазначених валют, також
    //програма має виробляти конвертацію з зазначених валют в гривню.
{
    public class Converter
    {
        private double usdRate;
        private double euroRate;
        private double rubRate;

        // Конструктор що ініціалізує поля відповідні курсу 3-х основних валют
        public Converter(double usd, double euro, double rub)
        {
            usdRate = usd;
            euroRate = euro;
            rubRate = rub;
        }

        // Конвертуємо гривню в інші валюти
        public double UahToUSD(double amount)
        {
            return amount / usdRate;
        }

        public double UahToEuro(double amount)
        {
            return amount / euroRate;
        }

        public double UahToRub(double amount)
        {
            return amount / rubRate;
        }

        // Конвертуємо інші валюти в гривню
        public double USDToUah(double amount)
        {
            return amount * usdRate;
        }

        public double EuroToUah(double amount)
        {
            return amount * euroRate;
        }

        public double RubToUah(double amount)
        {
            return amount * rubRate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
           
            Converter converter = new Converter(36.5, 40.0, 0.5);

            Console.WriteLine("Оберіть тип конвертації:");
            Console.WriteLine("1. UAH в USD");
            Console.WriteLine("2. UAH в EUR");
            Console.WriteLine("3. UAH в RUB");
            Console.WriteLine("4. USD в UAH");
            Console.WriteLine("5. EUR в UAH");
            Console.WriteLine("6. RUB в UAH");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Введіть суму в гривнях: ");
                    double uahToUsd = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{uahToUsd} ₴ = {converter.UahToUSD(uahToUsd)} $");
                    break;
                case 2:
                    Console.Write("Введіть суму в гривнях: ");
                    double uahToEuro = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{uahToEuro} ₴ = {converter.UahToEuro(uahToEuro)} €");
                    break;
                case 3:
                    Console.Write("Введіть суму в гривнях: ");
                    double uahToRub = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{uahToRub} ₴ = {converter.UahToRub(uahToRub)} ₽");
                    break;
                case 4:
                    Console.Write("Введіть суму в доларах: ");
                    double usdToUah = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{usdToUah} $ = {converter.USDToUah(usdToUah)} грн");
                    break;
                case 5:
                    Console.Write("Введіть суму в євро: ");
                    double euroToUah = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{euroToUah} € = {converter.EuroToUah(euroToUah)} грн");
                    break;
                case 6:
                    Console.Write("Введіть суму в рублях: ");
                    double rubToUah = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{rubToUah} ₽ = {converter.RubToUah(rubToUah)} грн");
                    break;
                default:
                    Console.WriteLine("Неправильний вибір.");
                    break;
            }

                Console.ReadLine();
        }
    }
}
