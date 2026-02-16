using System;

public class Journal
{
    private string name; 
    private int foundationYear;  
    private string description; 
    private string phone; 
    private string email; 

    public Journal()
    {
    }

    public Journal(string name, int foundationYear, string description, 
                   string phone, string email)
    {
        this.name = name;
        this.foundationYear = foundationYear;
        this.description = description;
        this.phone = phone;
        this.email = email;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetFoundationYear(int year)
    {
        this.foundationYear = year;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public void SetPhone(string phone)
    {
        this.phone = phone;
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }

    public string GetName()
    {
        return name;
    }

    public int GetFoundationYear()
    {
        return foundationYear;
    }

    public string GetDescription()
    {
        return description;
    }

    public string GetPhone()
    {
        return phone;
    }

    public string GetEmail()
    {
        return email;
    }

    public void InputData()
    {
        Console.Write("Введите название журнала: ");
        name = Console.ReadLine();
        
        Console.Write("Введите год основания: ");
        foundationYear = int.Parse(Console.ReadLine());
        
        Console.Write("Введите описание журнала: ");
        description = Console.ReadLine();
        
        Console.Write("Введите контактный телефон: ");
        phone = Console.ReadLine();
        
        Console.Write("Введите контактный e-mail: ");
        email = Console.ReadLine();
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Название: {name}");
        Console.WriteLine($"Год основания: {foundationYear}");
        Console.WriteLine($"Описание: {description}");
        Console.WriteLine($"Телефон: {phone}");
        Console.WriteLine($"E-mail: {email}");
        Console.WriteLine(new string('-', 50));
    }
}

class Program
{
    static void Main()
    {
        Journal journal1 = new Journal();
        journal1.InputData();
        
        Console.WriteLine("\nИнформация о журнале:");
        journal1.DisplayInfo();

        Console.WriteLine($"\nЖурнал: {journal1.GetName()}");
        Console.WriteLine($"Год основания: {journal1.GetFoundationYear()}");
        Console.WriteLine($"Контакт: {journal1.GetEmail()}");
    }
}
