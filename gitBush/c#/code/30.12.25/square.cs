using System;

public class Program
{
    public static void DrawSquare(int sideLength, char symbol)
    {
        for (int i = 0; i < sideLength; i++)
        {
            for (int j = 0; j < sideLength; j++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }
    
    static void Main()
    {
        DrawSquare(5, '*');
    }
}
