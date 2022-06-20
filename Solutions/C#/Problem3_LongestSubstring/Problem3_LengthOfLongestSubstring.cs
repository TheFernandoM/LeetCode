using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.Cs.Problem3LengthOfLongestSubstring
{
    /// <summary>
    /// #3: Longest Substring Without Repeating Characters
    /// 
    /// Given a string s, find the length of the longest substring without repeating characters.
    /// 
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// </summary>
    class Problem3LengthOfLongestSubstring
    {
        /// <summary>
        /// Returns the length of the longest substring (without any repeated characters).
        /// 
        /// This brute-force solution is slow but it works.
        /// </summary>
        public int LengthOfLongestSubstring(string s)
        {
            string substring = "";
            int longestSubstringLength = 0;
            int j = 0;

            for(int i = 0; i < s.Length; i++)
            {
                if (substring.Contains(s[i]))
                {
                    substring = "";
                    j++;
                    i = j - 1; // the index variable "i" is re-assigned whenever a repeat character is found. This is what causes such a long runtime
                    continue;
                }
                substring += s[i].ToString();
                longestSubstringLength = substring.Length > longestSubstringLength ? substring.Length : longestSubstringLength; // check if the current substring is the longest so far
            }
            return longestSubstringLength;
        }
    }
}
