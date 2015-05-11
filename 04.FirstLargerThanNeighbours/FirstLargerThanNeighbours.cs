using System;

class FirstLargerThanNeighbours
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 3, 4, 5, 1, 0, 5 };
        int[] nums2 = { 1, 3, 4, 5, 6, 7, 7 };
        int[] nums3 = { 1, 1, 1 };
        var i = GetFirstLargerIndex(nums);
        Console.WriteLine(i);
        i = GetFirstLargerIndex(nums2);
        Console.WriteLine(i);
        i = GetFirstLargerIndex(nums3);
        Console.WriteLine(i);
    }

    private static int GetFirstLargerIndex(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (IsLarger(nums, i)) 
            {
                return i;
            }
        }
        return -1;
    }

    private static bool IsLarger(int[] nums, int i)
    {
        bool startLoop = i == 0 ? true : nums[i] > nums[i - 1];
        bool endLoop = i == nums.Length - 1 ? true : nums[i] > nums[i + 1];
        bool larger = (startLoop && endLoop);
        return larger;
    }
}
