using System.Text;

namespace HW3_Task_2_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Завдання 2
            //Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
            //Напишіть програму -консольний калькулятор.
            //Створіть дві змінні з іменами operand1 і operand2. Задайте змінним деякі довільні значення.
            //Запропонуйте користувачеві ввести знак арифметичної операції. Прийміть значення, введене
            //користувачем, і помістіть його в строкову змінну sign.
            //Для організації вибору алгоритму обчислювального процесу використовуйте перемикач switch
            //Виведіть на екран результат виконання арифметичної операції.
            //У разі використання операції ділення, організуйте перевірку спроби ділення на нуль. І якщо така є, то
            //відмініть виконання арифметичної операції і повідомите про помилку користувача.

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double operand1, operand2, result;
            char sign;

            Console.WriteLine("Введіть перше число і натисніть Enter");
            operand1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть знак і натисніть Enter");
            sign = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введіть друге число і натисніть Enter");
            operand2 = Convert.ToDouble(Console.ReadLine());
            

            switch (sign)
            {
                case '+':
                    result = operand1 + operand2;
                    Console.WriteLine("Результат обчислення становить " + result);
                    break;
                case '-':
                    result = operand1 - operand2;
                    Console.WriteLine("Результат обчислення становить " + result);
                    break;
                case '*':
                    result = operand1 * operand2;
                    Console.WriteLine("Результат обчислення становить " + result);
                    break;
                case '/':
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Пртилка: ділення на 0 неможливе");
                    }
                    else
                    {
                        result = operand1 / operand2;
                    }
                    break;
            }
            }
    }
}
