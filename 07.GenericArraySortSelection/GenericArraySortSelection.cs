using System;
using System.Globalization;

class SortArrayNumsSelection
{
    static void Main(string[] args)
    {
        CultureInfo invC = CultureInfo.InvariantCulture;
        int[] nums = { 1, 3, 4, 5, 1, 0, 5 };
        string[] strings = { "zaz", "cba", "baa", "azis" };
        DateTime[] dates =
        {
            new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1),
        };
        Console.WriteLine(SortArray(nums));
        Console.WriteLine(SortArray(strings));
        Console.WriteLine(SortArray(dates));
    }

    private static string SortArray<T>(T[] nums) where T : IComparable<T>
    {
        int minI;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            minI = i;
            T temp = nums[minI];
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j].CompareTo(nums[minI])<0)
                {
                    minI = j;
                }
            }
            if (minI > i)
            {
                nums[i] = nums[minI];
                nums[minI] = temp;
            }
        }
        return string.Join(", ", nums);
    }
}
