using System;

    class LargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 3, 4, 5, 1, 0, 5};
            for (int i = 0; i < nums.Length; i++)
            {
                var larger = IsLarger(nums, i);
                Console.WriteLine(larger);
            }
        }

        private static bool IsLarger(int[] nums, int i)
        {
            bool startLoop = i == 0 ? true : nums[i] > nums[i - 1];
            bool endLoop = i == nums.Length - 1 ? true : nums[i] > nums[i + 1];
            bool larger = (startLoop && endLoop);
            return larger;
        }
    }
