using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

namespace HW6_Task2_Array_Exploring
{
    internal class Program
    {
        //        Завдання 2
        //Використовуючи Visual Studio, створіть проєкт по шаблоном ConsoleApplication.
        //Потрібно:
        //Створити масив розміру N елементів, заповнити його довільними цілими значеннями(розмір масиву
        //задає користувач).
        //Вивести на екран: найбільше значення масиву, найменше значення масиву, загальну суму всіх
        //елементів, середнє арифметичне всіх елементів, вивести всі непарні значення.
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введіть розмір масиву: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Введіть значення змінної {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int largest = numbers[0];

            int smallest = numbers[0];

            int sum = 0;

            int oddCount = 0;
                        
            int mean = (int)sum / size;

            foreach (int number in numbers)
            {
                if (number > largest)
                    largest = number;

                if (number < smallest)
                    smallest = number;

                sum += number;

                if (number % 2 != 0)
                {
                    Console.WriteLine($"Непарне значення: {number}");
                    oddCount++;
                }
            }

            Console.WriteLine($"Найбільше значення массиву: {largest}");

            Console.WriteLine($"Найменше значення массиву: {smallest}");

            Console.WriteLine($"Сума всіх елементів: {sum}");

            Console.WriteLine($"Середня арифметична всіх елементів: {mean}");

            Console.WriteLine($"Кількість непарних значень масиву: {oddCount}");

            Console.ReadLine();

        }
    }
}
