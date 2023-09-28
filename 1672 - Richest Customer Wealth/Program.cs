// See https://aka.ms/new-console-template for more information
public class Solution
{
    public int MaximumWealth(int[][] accounts)
    {
        int max = 0;

        for (int i = 0; i < accounts.Length; i++)
        {
            int cWealth = 0;

            foreach (int j in accounts[i])
            {
                cWealth += j;
            }

            if (cWealth > max)
            {
                max = cWealth;
            }
        }

        return max;
    }
}