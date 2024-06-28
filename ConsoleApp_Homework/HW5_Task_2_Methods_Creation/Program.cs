using static System.Net.Mime.MediaTypeNames;

namespace HW5_Task_2_Methods_Creation
{
    internal class Program
    {
        //        Завдання 2
        //Використовуючи Visual Studio, створіть проєкт за шаблоном Console Application.
        //Створіть чотири методи для виконання арифметичних операцій з наступними іменами: Add -
        //додавання, Sub - віднімання, Mul - множення, Div - ділення.Кожен метод має
        //приймати два цілочисельних аргументи і виводити на екран результат виконання арифметичної
        //операції, відповідної імені методу.Метод поділу Div повинен виконувати перевірку спроби ділення на
        //нуль.
        //Потрібно надати користувачеві можливість вводити з клавіатури значення операндів і знак
        //арифметичної операції — для виконання обчислень.

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введіть будь ласка перше число: ");
            int numb1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть будь ласка друге число: ");
            int numb2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть бажану арефметичну операцію (+ для додавання, - для віднімання, * для множення, / для ділення): ");
            char operation = Convert.ToChar(Console.ReadLine());

            switch (operation)
            {
                default:
                    Console.WriteLine("Invalid operation");
                    break;
                case '+':
                    Add(numb1, numb2);
                    break;
                case '-':
                    Sub(numb1, numb2);
                    break;
                case '*':
                    Mul(numb1, numb2);
                    break;
                case '/':
                    Div(numb1, numb2);
                    break;
            }

            Console.ReadLine();
        }

        static void Add(int a, int b)
        {
            Console.WriteLine($"Додавання: {a} + {b} = {a + b}");
        }

        static void Sub(int a, int b)
        {
            Console.WriteLine($"Віднімання: {a} - {b} = {a - b}");
        }

        static void Mul(int a, int b)
        {
            Console.WriteLine($"Множення: {a} * {b} = {a * b}");
        }

        static void Div(int a, int b)
        {
            if (b != 0)
            {
                Console.WriteLine($"Ділення: {a} / {b} = {a / b}");
            }
            else
            {
                Console.WriteLine("Ділення на нуль не можливе.");
            }
        }
    }
}
