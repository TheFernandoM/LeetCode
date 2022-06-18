using System;
namespace LeetCode.Solutions.Cs.Problem27RemoveElement
{
    /// <summary>
    /// Problem #27
    /// "Given an integer array nums and an integer val, remove all occurrences
    /// of val in nums in-place. The relative order of the elements may be
    /// changed.
    ///
    /// Do not allocate extra space for another array. You must do this by
    /// modifying the input array in-place with O(1) extra memory."
    /// 
    /// https://leetcode.com/problems/remove-element/
    /// </summary>
    public class Problem27RemoveElement
    {
        /// <summary>
        /// Runtime complexity: O(n), since it's just one for loop that iterates
        /// the entire length of the array.
        /// </summary>
        public int RemoveElement(int[] nums, int val)
        {
            // [Note]: I had to look at the LeetCode hints for this one after some failed attempts
            // the "simple" array questions tend to be trickier to think about than the "hard" ones
            int movingIndex = 0;
            int count = 0;

            for(int i = 0;i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    count++;
                }
                else
                {
                    nums[movingIndex] = nums[i];
                    movingIndex++;
                }
            }
            return (nums.Length - count);
        }

        /// <summary>
        /// THIS IS AN OLD VERSION THAT DOES NOT PROPERLY SOLVE ALL CASES.
        ///
        /// I've left it for posterity, to show what a Work-In-Progress incorrect
        /// approach looks like.
        /// </summary>
        public int RemoveElement_OLD(int[] nums, int val)
        {
            int lastIndex = nums.Length - 1;
            bool hasLastNumBeenReplaced = false; // "has the last number in array been replaced yet?"
            bool shouldIndexBeDecremented = false;
            int count = 0;

            for(int i = 0; i < nums.Length - 1; i++)
            {
                if(nums[i] == val)
                {
                    count++;
                    int lastNumber = nums[lastIndex];

                    if (!hasLastNumBeenReplaced)
                    {
                        if(lastNumber != val) nums[i] = lastNumber;
                        hasLastNumBeenReplaced = true;
                        shouldIndexBeDecremented = true;
                    }
                    nums[lastIndex] = nums[i]; // move the number to the back of the array


                    // move down all the numbers except for the last number
                    for(int j = i; j < lastIndex - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    if (shouldIndexBeDecremented)
                    {
                        i--;
                        shouldIndexBeDecremented = false;
                    }
                }
            }

            return (nums.Length - count + 1);
        }
    }
}
