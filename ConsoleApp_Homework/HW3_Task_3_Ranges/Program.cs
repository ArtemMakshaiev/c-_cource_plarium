﻿using System.Text;

namespace HW3_Task_3_Ranges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Завдання 3
            //Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
            //Напишіть програму визначення, чи потрапляє вказане користувачем число від 0 до 100 в числовий
            //проміжок[0 - 14][15 - 35][36 - 50][50 - 100].Якщо так, то вкажіть, в який саме проміжок.Якщо
            //користувач вказує число, що не входить ні в один з наявних числових проміжків , то виводиться
            //відповідне повідомлення.

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть число від 0 до 100: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n >= 0 && n <= 14)
            {
                Console.WriteLine("Введене число відноситься до числового проміжку [0 - 14]");
            }
            else if (n >= 15 && n <= 35)
            {
                Console.WriteLine("Введене число відноситься до числового проміжку [15 - 35]");
            }
            else if (n >= 36 && n <= 50)
            {
                Console.WriteLine("Введене число відноситься до числового проміжку [36 - 50]");
            }
            else if (n >= 51 && n <= 100)
            {
                Console.WriteLine("Введене число відноситься до числового проміжку [51 - 100]");
            }
            else
            {
                Console.WriteLine("Введене число не відноситься до жодного із зазначених числових проміжків.");



            }
        }
    }
}