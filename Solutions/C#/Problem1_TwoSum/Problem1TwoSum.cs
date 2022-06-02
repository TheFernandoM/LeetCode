using System;
namespace LeetCode.Solutions.Cs.Problem1TwoSum
{
    public class Problem1TwoSum
    {
        /// <summary>
        ///
        /// Author: Fernando Molina
        ///
        /// Brute force solution, O(n ** 2) runtime
        /// </summary>
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j }; // answer: indices [i, j]
                    }
                }
            }
            return null; // this line is only reached if there's no solution
        }
    }
}
