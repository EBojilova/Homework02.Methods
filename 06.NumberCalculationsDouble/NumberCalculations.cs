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
        double[] numsD = { 1.1, 3.3, 4.4, 5.5, 1.1, 0.000000003, 5.2 };
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

    private static double Min(double[] nums)
    {
        double temp;
        for (int j = 1; j < nums.Length; j++)
        {
            if (nums[0] > nums[j])
            {
                temp = nums[0];
                nums[0] = nums[j];
                nums[j] = temp;
            }
        }
        double min = nums[0];
        return min;
    }

    private static double Max(double[] nums)
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
        double max = nums[0];
        return max;
    }

    private static double Average(double[] nums)
    {
        var average = Sum(nums) / nums.Length;
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

}
