namespace HW6_Task3_Methods_Creation
{
    internal class Program
    {
        //        Завдання 3
        //Використовуючи Visual Studio, створіть проєкт за шаблоном ConsoleApplication.
        //Потрібно:
        //1) Створити метод MyReverse(int[] array), який приймає в якості аргументу масив цілочисельних
        //елементів і повертає інвертований масив(елементи масиву в зворотному порядку).
        //2) Створіть метод int[] SubArray(int[] array, int index, int count). Метод повертає частину
        //отриманого в якості аргументу масиву, починаючи з позиції, зазначеної в аргументі index,
        //розмірністю, яка відповідає значенню аргументу count.
        //Якщо аргумент count містить значення більше, ніж кількість елементів, які входять в обрану частину
        //вихідного масиву(від зазначеного індексу index до індексу останнього елемента), то при формуванні
        //нового масиву розмірністю в count, заповніть одиницями ті елементи, які були скопійовані з вихідного
        //масиву.
        static int[] MyReverse(int[] array)
        {
            int[] reversedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length - 1 - i];
            }
            return reversedArray;
        }
        static int[] SubArray(int[] array, int index, int count)
        {
            int[] resultArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                if (index + i < array.Length)
                {
                    resultArray[i] = array[index + i];
                }
                else
                {
                    resultArray[i] = 1;
                }
            }
            return resultArray;
        }
        static void Main(string[] args)     
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[] originalArray = { 25, 30, 40, 45, 50, 55 };

            //тестуємо MyReverse method
            int[] reversedArray = MyReverse(originalArray);
            Console.WriteLine("Інвертований масив:");
            foreach (int num in reversedArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            //тестуємо SubArray method
            int[] subArray = SubArray(originalArray, 1, 8);
            Console.WriteLine("Підмасив:");
            foreach (int num in subArray)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();
        }
    }
}
