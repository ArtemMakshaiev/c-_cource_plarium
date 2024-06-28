namespace HW6_Task3_Methods_Creation1
{
    internal class Program
    {
        //        Завдання 4
        //Використовуючи Visual Studio, створіть с# проєкт за шаблоном ConsoleApplication.
        //Потрібно:
        //Створити метод, який буде виконувати збільшення довжини масиву, переданого як аргумент, на 1 елемент.
        //Елементи масиву повинні зберегти своє значення і порядок індексів.
        //Створіть метод, який приймає два аргументи, перший аргумент - типу int[] array, другий аргумент - типу int value.
        //У тілі методу реалізуйте можливість додавання другого аргументу методу в масив за індексом 0, при цьому довжина
        //нового масиву повинна збільшитися на 1 елемент, а елементи одержуваного масиву у якості першого аргументу повинні
        //скопіюватися в новий масив починаючи з індексу 1.

        static int[] IncreaseArrayLength(int[] array)
        {
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }

        static int[] AddElementAtIndex(int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[0] = value;
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }
            return newArray;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[] originalArray = { 20, 30, 40, 50, 60, 70 };

            //тестуємо IncreaseArrayLength method
            int[] newArray = IncreaseArrayLength(originalArray);
            Console.WriteLine("Новий масив із збільшною довжиною:");
            foreach (int num in newArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            //тестуємо AddElementAtIndex method
            int valueToAdd = 10;
            int[] updatedArray = AddElementAtIndex(originalArray, valueToAdd);
            Console.WriteLine("Оновлений масив із новим елементом доданим в Індекс 0:");
            foreach (int num in updatedArray)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();
        }
    }
}
