public class Solution
{
    public int RomanToInt(string s)
    {
        char[] chars = s.ToCharArray();
        int[] numeralAsInt = new int[chars.Length];
        List<int> temp = new List<int>(); ;
        int sum;
        int total = 0;
        int restartPos = 0;
        for (int i = 0; i < chars.Length; i++)
        {
            switch (chars[i])
            {
                case 'I':
                    numeralAsInt[i] = 1;
                    break;
                case 'V':
                    numeralAsInt[i] = 5;
                    break;
                case 'X':
                    numeralAsInt[i] = 10;
                    break;
                case 'L':
                    numeralAsInt[i] = 50;
                    break;
                case 'C':
                    numeralAsInt[i] = 100;
                    break;
                case 'D':
                    numeralAsInt[i] = 500;
                    break;
                case 'M':
                    numeralAsInt[i] = 1000;
                    break;
            }
        }
        for (int ctr = 0; ctr < numeralAsInt.Length;)
        {

            for (int ctr2 = ctr; ctr2 < numeralAsInt.Length; ctr2++)
            {
                temp.Add(numeralAsInt[ctr2]);

                if (ctr2 < numeralAsInt.Length - 1)
                {
                    if (numeralAsInt[ctr2 + 1] < numeralAsInt[ctr2])
                    {
                        ctr = ctr2 + 1;

                        break;
                    }
                }
                else if (ctr2 == numeralAsInt.Length - 1)
                {
                    ctr = ctr2 + 1;
                }
            }
            if (temp.Count > 0)
            {
                sum = temp.Last();
                if (temp.First() == temp.Last())
                {
                    for (int j = temp.Count - 2; j >= 0; j--)
                    {
                        sum += temp[j];
                    }
                }
                else
                {
                    for (int j = temp.Count - 2; j >= 0; j--)
                    {
                        sum -= temp[j];
                    }
                }

                total += sum;
                temp.Clear();
            }
        }
        return total;
    }
}