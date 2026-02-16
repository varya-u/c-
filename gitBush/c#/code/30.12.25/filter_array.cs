using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static int[] FilterArray(int[] originalArray, int[] filterArray)
    {
        HashSet<int> filterSet = new HashSet<int>(filterArray);
        List<int> result = new List<int>();
        
        foreach (int num in originalArray)
        {
            if (!filterSet.Contains(num))
            {
                result.Add(num);
            }
        }
        
        return result.ToArray();
    }
    
    static void Main()
    {
        int[] original = { 1, 2, 6, -1, 88, 7, 6 };
        int[] filter = { 6, 88, 7 };
        int[] result = FilterArray(original, filter);
        
        Console.WriteLine("Результат: " + string.Join(" ", result));
    }
}
