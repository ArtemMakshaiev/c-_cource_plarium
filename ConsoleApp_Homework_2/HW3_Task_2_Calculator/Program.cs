using System.Text;

namespace HW3_Task_2_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
