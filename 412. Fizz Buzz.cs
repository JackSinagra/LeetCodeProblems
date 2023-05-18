public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        string[] final = new string[n];
        for (int i = 1; i < n + 1; i++)
        {
            if (i % 3 == 0)
            {
                final[i - 1] += "Fizz";
            }
            if (i % 5 == 0)
            {
                final[i - 1] += "Buzz";
            }
            if (i % 3 != 0 && i % 5 != 0)
            {
                final[i - 1] += i.ToString();
            }
        }
        return final;
    }
}
