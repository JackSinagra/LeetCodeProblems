/* initial solution
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string output = "";
        string shortest = strs.First(e => e.Length == strs.Min(y => y.Length));
        if (strs.Length == 1)
        {
            return shortest;
        }
        for (int i = 0; i < shortest.Length; i++)
        {
            string c = shortest.Substring(0, i + 1);
            for (int j = 0; j < strs.Length; j++)
            {
                if (strs[j].IndexOf(c) != 0)
                {
                    return shortest.Substring(0, i);

                }
                output = shortest.Substring(0, i + 1);
            }
        }
        return output;
    }
}
*/

// optimized solution
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string shortest = strs.First(e => e.Length == strs.Min(y => y.Length));
        for (int i = 0; i < shortest.Length; i++)
        {
            for (int j = 0; j < strs.Length; j++)
            {
                if (strs[j].IndexOf(shortest.Substring(0, i + 1)) != 0)
                {
                    return shortest.Substring(0, i);
                }
            }
        }
        return shortest;
    }
}