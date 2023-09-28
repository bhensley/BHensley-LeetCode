public class Solution
{
    public static int[] RunningSum(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] = nums[i - 1] + nums[i];
        }
        GC.Collect();
        return nums;
    }
    
    public static void Main(string[] args)
    {
        int[] nums = new int[] { 1, 1, 1, 1, 1 };
        int[] runSum = RunningSum(nums);
        
        foreach(int i in runSum)
        {
            System.Console.WriteLine(i);    
        }
    }   
}