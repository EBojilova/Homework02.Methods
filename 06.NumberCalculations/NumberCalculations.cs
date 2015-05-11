using System;
using System.Linq;

class NumberCalculations
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 3, 4, 5, 1, 0, 5 };
        Console.WriteLine("Round Numbers");
        Console.WriteLine("Min:{0}, Max:{1}, Sum:{2}, Average:{3}", Min(nums), Max(nums), Sum(nums), Average(nums));
        Console.WriteLine("Min:{0}, Max:{1}, Sum:{2}, Average:{3}", nums.Min(), nums.Max(), nums.Sum(), nums.Average());
        decimal[] numsD = { 1.1M, 3.3M, 4.4M, 5.5M, 1.1M, 0.000000003M, 5.2M };
        Console.WriteLine("Float Numbers");
        Console.WriteLine("Min:{0}, Max:{1}, Sum:{2}, Average:{3}", Min(numsD), Max(numsD), Sum(numsD), Average(numsD));
        Console.WriteLine("Min:{0}, Max:{1}, Sum:{2}, Average:{3}", numsD.Min(), numsD.Max(), numsD.Sum(), numsD.Average());
    }

    private static int Min(int[] nums)
    {
        for (int j = 1; j < nums.Length; j++)
        {
            if (nums[0] > nums[j])
            {
                nums[0] = nums[0] + nums[j];
                nums[j] = nums[0] - nums[j];
                nums[0] = nums[0] - nums[j];
            }
        }
        int min = nums[0];
        return min;
    }

    private static int Max(int[] nums)
    {
        for (int j = 1; j < nums.Length; j++)
        {
            if (nums[0] < nums[j])
            {
                nums[0] = nums[0] + nums[j];
                nums[j] = nums[0] - nums[j];
                nums[0] = nums[0] - nums[j];
            }
        }
        int max = nums[0];
        return max;
    }

    private static double Average(int[] nums)
    {
        var average = (double)Sum(nums) / nums.Length;
        return average;
    }

    private static int Sum(int[] nums)
    {
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum;
    }

    private static decimal Min(decimal[] nums)
    {
        decimal temp;
        for (int j = 1; j < nums.Length; j++)
        {
            if (nums[0] > nums[j])
            {
                temp = nums[0];
                nums[0] = nums[j];
                nums[j] = temp;
            }
        }
        decimal min = nums[0];
        return min;
    }

    private static decimal Max(decimal[] nums)
    {
        for (int j = 1; j < nums.Length; j++)
        {
            if (nums[0] < nums[j])
            {
                nums[0] = nums[0] + nums[j];
                nums[j] = nums[0] - nums[j];
                nums[0] = nums[0] - nums[j];
            }
        }
        decimal max = nums[0];
        return max;
    }

    private static decimal Average(decimal[] nums)
    {
        var average = Sum(nums) / nums.Length;
        return average;
    }

    private static decimal Sum(decimal[] nums)
    {
        decimal sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum;
    }

}
