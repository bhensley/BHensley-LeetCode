public class Programn
{
    public static void Main(string[] args)
    {
        // Add the project being worked on as a dependency, instantiate the class, and call the method
        // Solution solution = new Solution(); Blah blah blah
        LeetCode.Solution fb = new LeetCode.Solution();
        IList<string> fbOut = fb.FizzBuzz(3);
        foreach (string s in fbOut)
        {
            Console.WriteLine(s);
        }
    }
}