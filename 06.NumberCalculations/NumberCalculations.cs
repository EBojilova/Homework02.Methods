using System;
using System.Linq;
using System.Runtime.InteropServices;

class NumberCalculations
{
    static void Main(string[] args)
    {
        double[] nums = { 1, 3, 4, 5, 1, 0.000000000003, 5 };
        Console.WriteLine("Round Numbers");
        Console.WriteLine("Min:{0}, Max:{1}, Sum:{2}, Average:{3}", Min(nums), Max(nums), Sum(nums), Average(nums));
        //Console.WriteLine("Min:{0}, Max:{1}, Sum:{2}, Average:{3}", nums.Min(), nums.Max(), nums.Sum(), nums.Average());
        decimal[] numsD = { 1.1M, 3.3M, 4.4M, 5.5M, 1.1M, 0.000000003M, 5.2M };
        Console.WriteLine("Float Numbers");
        Console.WriteLine("Min:{0}, Max:{1}, Sum:{2}, Average:{3}", Min(numsD), Max(numsD), Sum(numsD), Average(numsD));
        //Console.WriteLine("Min:{0}, Max:{1}, Sum:{2}, Average:{3}", numsD.Min(), numsD.Max(), numsD.Sum(), numsD.Average());
    }

    private static double Min(double[] nums)
    {
        double min = double.MaxValue;
        for (int j = 1; j < nums.Length; j++)
        {
            if (min > nums[j])
            {
                min = nums[j];
            }
        }
        return min;
    }

    private static double Max(double[] nums)
    {
        double max = double.MinValue;
        for (int j = 1; j < nums.Length; j++)
        {
            if (max < nums[j])
            {
                max = nums[j];
            }
        }
        return max;
    }

    private static double Average(double[] nums)
    {
        var average = (double)Sum(nums) / nums.Length;
        return average;
    }

    private static double Sum(double[] nums)
    {
        double sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum;
    }

    private static decimal Min(decimal[] nums)
    {
        decimal min = decimal.MaxValue;
        for (int j = 1; j < nums.Length; j++)
        {
            if (min > nums[j])
            {
                min = nums[j];
            }
        }
        return min;
    }

    private static decimal Max(decimal[] nums)
    {
        decimal max = decimal.MinValue;
        for (int j = 1; j < nums.Length; j++)
        {
            if (max < nums[j])
            {
                max = nums[j];
            }
        }
        return max;
    }

    private static decimal Average(decimal[] nums)
    {
        var average = (decimal)Sum(nums) / nums.Length;
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
