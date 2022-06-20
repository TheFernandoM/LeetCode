using System;
namespace LeetCode.Solutions.Cs.Problem9PalindromeNumber
{
    /// <summary>
    /// Problem #9
    /// Given an integer x, return true if x is palindrome integer.
    /// An integer is a palindrome when it reads the same backward as forward.
    /// 
    /// https://leetcode.com/problems/palindrome-number/
    /// </summary>
    public class Problem9PalindromeNumber
    {
        /// <summary>
        /// Brute-force solution.
        /// 
        /// Runtime: O(n)
        /// </summary>
        public bool IsPalindrome(int x)
        {

            if (x < 0) { return false; } // negative numbers are not palindrome numbers
            if (x < 10) { return true; } // any single-digit number is a palindrome number
            var numString = x.ToString();

            int j = numString.Length - 1;
            for (int i = 0; i < numString.Length / 2; i++)
            {
                if (numString[i] != numString[j]) { return false; }
                j--;
            }
            return true;
        }
    }
}
