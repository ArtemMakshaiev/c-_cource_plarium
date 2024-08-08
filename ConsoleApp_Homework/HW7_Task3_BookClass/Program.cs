using System;
using System.Text;

namespace HW7_Task3_BookClass
        //    Завдання 3
        //Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
        //потрібно:
        //Створити клас Book.Створити класи Title, Author і Content, кожен з яких повинен містити одне строкове
        //поле і метод void Show().
        //Реалізуйте можливість додавання в книгу назви книги, імені автора і змісту.
        //Виведіть на екран різними кольорами за допомогою методу Show () назва книги, ім'я автора та зміст.
{
        class Title
    {
        private string title;

        public Title(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan; 
            Console.WriteLine($"Назва: {title}");
            Console.ResetColor(); 
        }
    }
        class Author
    {
        private string authorName;

        public Author(string authorName)
        {
            this.authorName = authorName;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine($"Автор: {authorName}");
            Console.ResetColor(); 
        }
    }

    class Content
    {
        private string content;

        public Content(string content)
        {
            this.content = content;
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.WriteLine($"Зміст: {content}");
            Console.ResetColor(); 
        }
    }
    
    class Book
    {
        public Title BookTitle { get; set; }
        public Author BookAuthor { get; set; }
        public Content BookContent { get; set; }

        public void AddDetails(string title, string authorName, string content)
        {
            BookTitle = new Title(title);
            BookAuthor = new Author(authorName);
            BookContent = new Content(content);
        }

        public void ShowDetails()
        {
            BookTitle.Show();
            BookAuthor.Show();
            BookContent.Show();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Не розумію чому при запуску програми не виводиться book details Українстькою ((
            Console.OutputEncoding = Encoding.UTF8;

            Book book = new Book();

            Console.WriteLine("Введіть назву книги:");
            string title = Console.ReadLine();

            Console.WriteLine("Введіть ім'я автора:");
            string authorName = Console.ReadLine();

            Console.WriteLine("Введіть зміст:");
            string content = Console.ReadLine();

            book.AddDetails(title, authorName, content);

            Console.WriteLine("\nДеталі книги:");
            book.ShowDetails();

            Console.WriteLine("\nНатисніть будь-яку клавішу, щоб вийти...");
            Console.ReadKey();
        }
    }
}
