using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введiть назву книги: ");
        string sTitle = Console.ReadLine();

        Console.Write("Введiть автора книги: ");
        string sAuthor = Console.ReadLine();

        Console.Write("Введiть кiлькiсть сторiнок: ");
        string sNumPages = Console.ReadLine();

        Console.Write("Введiть загальну кiлькiсть слiв у книзi: ");
        string sWordCount = Console.ReadLine();

        Console.Write("Введiть видавця книги: ");
        string sPublisher = Console.ReadLine();

        Console.Write("Введiть рiк видання: ");
        string sYearPublished = Console.ReadLine();

        Console.Write("Введiть мову книги: ");
        string sLanguage = Console.ReadLine();

       
        Book OurBook = new Book();
        OurBook.Title = sTitle;
        OurBook.Author = sAuthor;
        OurBook.NumPages = int.Parse(sNumPages);
        OurBook.WordCount = int.Parse(sWordCount);
        OurBook.Publisher = sPublisher;
        OurBook.YearPublished = int.Parse(sYearPublished);
        OurBook.Language = sLanguage;

        
        double wordsPerPage = OurBook.CalculateWordsPerPage();

        
        Console.WriteLine("\nIнформацiя про книгу:");
        Console.WriteLine("-------------------------");
        Console.WriteLine("Назва книги: " + OurBook.Title);
        Console.WriteLine("Автор: " + OurBook.Author);
        Console.WriteLine("Кiлькiсть сторiнок: " + OurBook.NumPages);
        Console.WriteLine("Кiлькiсть слiв: " + OurBook.WordCount);
        Console.WriteLine("Видавець: " + OurBook.Publisher);
        Console.WriteLine("Рiк видання: " + OurBook.YearPublished);
        Console.WriteLine("Мова: " + OurBook.Language);
        Console.WriteLine($"Кiлькiсть слiв на сторiнцi: {wordsPerPage}");

        Console.WriteLine();
        Console.Write("Натиснiть будь-яку клавішу, щоб закрити...");
        Console.ReadKey();
    }
}