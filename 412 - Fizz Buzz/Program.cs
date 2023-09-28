namespace LeetCode
{
    public class Solution
    {
        public IList<string> FizzBuzz(int n)
        {
            IList<string> fbOut = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                fbOut.Add(
                    (i % 3 == 0 && i % 5 == 0) ? "FizzBuzz" :
                        (i % 3 == 0) ? "Fizz" :
                            (i % 5 == 0) ? "Buzz" :
                                i.ToString()
                );
            }
            return fbOut;
        }
    }
}