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
