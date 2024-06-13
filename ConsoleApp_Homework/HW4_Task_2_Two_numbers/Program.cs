namespace HW4_Task_2_Two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        Завдання 2
            //Використовуючи Visual Studio, створіть проєкт за шаблоном Console Application.
            //Дано два числа A і B(A<B), виведіть суму всіх чисел, розташованих між даними числами, на екран.
            //Дано два числа A і B(A<B), виведіть всі непарні значення, розташовані між даними числами.

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Cумa всіх чисел, розташованих між A та B
            int A = 2;
            int B = 9;
            int summ = 0;
            for (int i = A; i <= B; i++)
            {
                summ += i;
            }
            Console.WriteLine($"Сума всіх чисел розташованих між {A} та {B} становить: {summ}");

            // Print all odd values between A and B
            int number = A;
            Console.WriteLine($"Всі непарні значення розташовані між {A} та {B}:");
            while (number <= B)
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine(number);
                }
                number++;
            }
        }
    }
}
