using System;

public class Book
{
    private string[] chapters;

    public Book()
    {
        chapters = new string[20];
    }

    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < chapters.Length)
            {
                return chapters[index] ?? "Пустая глава";
            }
            throw new IndexOutOfRangeException("Неправильный индекс главы");
        }

        set
        {
            if (index >= 0 && index < chapters.Length)
            {
                chapters[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Неправильный индекс главы");
            }
        }
    }

    public override string ToString()
    {
        string result = "";
        for (int i = 0; i < chapters.Length; i++)
        {
            if (!string.IsNullOrEmpty(chapters[i]))
            {
                result += $"{i + 1}. {chapters[i]}\n";
            }
        }
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var book = new Book();

        book[0] = "Введение";
        book[1] = "Глава 1";

        Console.WriteLine(book[0]);
        Console.WriteLine(book);
    }
}
