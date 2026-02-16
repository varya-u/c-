using System;

public class Shop
{
    private string name; 
    private string address;  
    private string description;  
    private string phone; 
    private string email;   

    public Shop()
    {
    }

    public Shop(string name, string address, string description, 
                string phone, string email)
    {
        this.name = name;
        this.address = address;
        this.description = description;
        this.phone = phone;
        this.email = email;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetAddress(string address)
    {
        this.address = address;
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

    public string GetAddress()
    {
        return address;
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
        Console.Write("Введите название магазина: ");
        name = Console.ReadLine();
        
        Console.Write("Введите адрес магазина: ");
        address = Console.ReadLine();
        
        Console.Write("Введите описание профиля: ");
        description = Console.ReadLine();
        
        Console.Write("Введите контактный телефон: ");
        phone = Console.ReadLine();
        
        Console.Write("Введите контактный e-mail: ");
        email = Console.ReadLine();
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Название: {name}");
        Console.WriteLine($"Адрес: {address}");
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
        Shop shop1 = new Shop();
        shop1.InputData();
        
        Console.WriteLine("\nИнформация о магазине:");
        shop1.DisplayInfo();

        Console.WriteLine($"\nМагазин: {shop1.GetName()}");
        Console.WriteLine($"Адрес: {shop1.GetAddress()}");
        Console.WriteLine($"Контакт: {shop1.GetPhone()}");
    }
}
