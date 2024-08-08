using System;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace HW8_Task3_Sallary

    //    Завдання 3
    //Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    //Потрібно:
    //Створити клас Employee.
    //У тілі класу створити користувальницький конструктор, який приймає два строкових аргументи, і
    //ініціалізує поля, відповідні прізвища та імені співробітника.
    //Створити метод розраховує оклад співробітника (в залежності від посади і стажу) і податковий збір.
    //Написати програму, яка виводить на екран інформацію про співробітника(прізвище, ім'я, посада), оклад
    //і податковий збір.
{
    public class Employee
    {
        private string lastName;
        private string firstName;
        private string position;
        private double salary;

        // Користувальницький конструктор, який приймає два строкових аргументи, і ініціалізує поля, відповідні прізвища та імені співробітника.
        public Employee(string lastName, string firstName, string position)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.position = position;
            CalculateSalary();
        }

        // Метод що що розраховує ЗП робітника залежно від позиції та стажу
        private void CalculateSalary()
        {
            switch (position.ToLower())
            {
                case "менеджер":
                    salary = 30000; // ЗП менеджера
                    break;
                case "розробник":
                    salary = 40000; // ЗП розробника
                    break;
                case "аналітик":
                    salary = 35000; // ЗП анілітика
                    break;
                default:
                    salary = 20000; // ЗП за замовченням
                    break;
            }
        }

        // Метод що розраховує податок 20%
        public double CalculateTax()
        {
            return salary * 0.20;
        }

        // Метод що відображає інформацію про робітника
        public void DisplayInfo()
        {
            
            Console.WriteLine($"Прізвище: {lastName}");
            Console.WriteLine($"Ім'я: {firstName}");
            Console.WriteLine($"Посада: {position}");
            Console.WriteLine($"Зарплата: {salary} грн");
            Console.WriteLine($"Податок: {CalculateTax()} грн");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть прізвище працівника: ");
            string lastName = Console.ReadLine();

            Console.Write("Введіть ім'я працівника: ");
            string firstName = Console.ReadLine();

            Console.Write("Введіть посаду працівника (менеджер/розробник/аналітик): ");
            string position = Console.ReadLine();

            Employee employee = new Employee(lastName, firstName, position);

            employee.DisplayInfo();
            Console.ReadLine();
        }
    }
}
