using System;

public class Book
{
    public string Title;
    public string Author;
    public int NumPages;
    public int WordCount;
    public string Publisher;
    public int YearPublished;
    public string Language;


    public double CalculateWordsPerPage()
    {
        if (NumPages > 0)
        {
            return (double)WordCount / NumPages;
        }
        else
        {
            Console.WriteLine("Кількість сторінок не може бути 0 або менше.");
            return 0;
        }
    }
}
