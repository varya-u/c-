using System;

public class Website
{
    private string name; 
    private string url; 
    private string description; 
    private string ipAddress;  

    public Website()
    {
    }

    public Website(string name, string url, string description, string ipAddress)
    {
        this.name = name;
        this.url = url;
        this.description = description;
        this.ipAddress = ipAddress;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetUrl(string url)
    {
        this.url = url;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public void SetIpAddress(string ipAddress)
    {
        this.ipAddress = ipAddress;
    }

    public string GetName()
    {
        return name;
    }

    public string GetUrl()
    {
        return url;
    }

    public string GetDescription()
    {
        return description;
    }

    public string GetIpAddress()
    {
        return ipAddress;
    }

    public void InputData()
    {
        Console.Write("Введите название сайта: ");
        name = Console.ReadLine();
        
        Console.Write("Введите URL сайта: ");
        url = Console.ReadLine();
        
        Console.Write("Введите описание сайта: ");
        description = Console.ReadLine();
        
        Console.Write("Введите IP адрес сайта: ");
        ipAddress = Console.ReadLine();
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Название: {name}");
        Console.WriteLine($"URL: {url}");
        Console.WriteLine($"Описание: {description}");
        Console.WriteLine($"IP адрес: {ipAddress}");
        Console.WriteLine(new string('-', 40));
    }
}

class Program
{
    static void Main()
    {
        Website site1 = new Website();
        site1.InputData();
        
        Console.WriteLine("\nИнформация о сайте:");
        site1.DisplayInfo();

        Console.WriteLine($"Название сайта: {site1.GetName()}");
        Console.WriteLine($"IP: {site1.GetIpAddress()}");
    }
}
