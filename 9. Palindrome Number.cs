using System;

public class Solution9
{
    public bool IsPalindrome(int x)
    {
        bool palindrome = true;
        int remainder = x;
        List<int> ints = new List<int>();

        if (x < 0)
        {
            palindrome = false;
        }
        else
        {
            while (x != 0)
            {
                remainder = x % 10;
                ints.Add(remainder);
                x = x / 10;
            }

            int elements = ints.Count();
            for (int i = 0; i < elements / 2; i++)
            {
                if (ints[i] == ints[elements - 1 - i])
                {
                    palindrome = true;
                }
                else if (ints[i] != ints[elements - 1 - i])
                {
                    palindrome = false;
                    break;
                }
        }
    }
    return palindrome;
}

