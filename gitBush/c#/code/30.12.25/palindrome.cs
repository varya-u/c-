using System;

public class Program
{
    public static bool IsPalindrome(int number)
    {
        string numStr = number.ToString();
        int left = 0;
        int right = numStr.Length - 1;
        
        while (left < right)
        {
            if (numStr[left] != numStr[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
    
    static void Main()
    {
        Console.WriteLine(IsPalindrome(1221)); 
        Console.WriteLine(IsPalindrome(3443));   
        Console.WriteLine(IsPalindrome(7854)); 
    }
}

