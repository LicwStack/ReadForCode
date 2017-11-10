using System;

namespace leetcode
{
    internal class Program
    {
        private static void Main()
        {
            var solution = new Solution();
            var arr = new[] { 2, 7, 11, 15 };

            foreach (var i in solution.TwoSum(arr, 9))
            {
                Console.WriteLine(i);
            }
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var arr = new int[2];
            for (var i = 0; i < nums.Length - 1; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] != target) continue;
                    arr[0] = i;
                    arr[1] = j;
                }
            }
            return arr;
        }
    }
}
