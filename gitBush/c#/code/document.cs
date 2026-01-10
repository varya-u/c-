using System;
using System.Collections.Generic;

public abstract class Document
{
    public string Author { get; set; }

    public abstract void Render();
}

public class TextDocument : Document
{
    public string Content { get; set; }

    public TextDocument(string author, string content)
    {
        Author = author;
        Content = content;
    }

    public override void Render()
    {
        Console.WriteLine($"Текстовый документ от {Author}:");
        Console.WriteLine(Content);
        Console.WriteLine();
    }
}

public class ImageDocument : Document
{
    public string Resolution { get; set; }

    public ImageDocument(string author, string resolution)
    {
        Author = author;
        Resolution = resolution;
    }

    public override void Render()
    {
        Console.WriteLine($"Изображение от {Author}, разрешение: {Resolution}");
        Console.WriteLine("Рендерим изображение...");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        List<Document> documents = new List<Document>();

        documents.Add(new TextDocument("Иванов", "Это пример текстового документа."));
        documents.Add(new ImageDocument("Петров", "1920x1080"));
        documents.Add(new TextDocument("Сидоров", "Ещё один текстовый документ."));

        Console.WriteLine("Рендерим все документы:\n");
        foreach (Document doc in documents)
        {
            doc.Render(); 
        }

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
