using System;
namespace LeetCode.Solutions.Cs.Problem4MedianOfTwoSortedArrays
{
    /// <summary>
    /// "Given two sorted arrays nums1 and nums2 of size m and n respectively,
    /// return the median of the two sorted arrays. The overall run time
    /// complexity should be O(log (m+n))."
    /// 
    /// https://leetcode.com/problems/median-of-two-sorted-arrays/
    /// </summary>
    public class Problem4MedianOfTwoSortedArraysTest
    {
        /// <summary>
        /// Brute-force approach, using built-in Array.Sort() method
        /// </summary>
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] mergedArray = new int[nums1.Length + nums2.Length];

            nums1.CopyTo(mergedArray, 0);
            nums2.CopyTo(mergedArray, nums1.Length);

            Array.Sort(mergedArray); // alternative: make my own quicksort implementation. Easier to use built-in sort

            if(mergedArray.Length % 2 == 0) // "if there are even number of ints in the array"
            {
                int middleIndex = (mergedArray.Length / 2) - 1; // -1 is because array indices start at 0, but Length counting starts at 1. The difference is 1.
                double num1 = mergedArray[middleIndex];
                double num2 = mergedArray[middleIndex + 1];
                return (num1 + num2) / 2;
            }
            if(mergedArray.Length % 2 == 1) // "if there are odd number of ints in the array"
            {
                int middleIndex = (int) Math.Floor(mergedArray.Length / 2.0d);
                return mergedArray[middleIndex]; // return the middle index
            }
            return -1; // this line is only reached if there is no valid answer

        }
    }
}
