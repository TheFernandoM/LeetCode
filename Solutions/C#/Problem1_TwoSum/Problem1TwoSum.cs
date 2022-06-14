using System;
namespace LeetCode.Solutions.Cs.Problem1TwoSum
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target
    /// 
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    public class Problem1TwoSum
    {
        /// <summary>
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
