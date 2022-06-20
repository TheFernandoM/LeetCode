using System;
namespace LeetCode.Solutions.Cs.Problem7ReverseInteger
{
    /// <summary>
    /// "Given a signed 32-bit integer x, return x with its digits reversed.
    /// If reversing x causes the value to go outside the signed 32-bit integer
    /// range [-231, 231 - 1], then return 0.
    // Assume the environment does not allow you to store 64-bit integers(signed or unsigned)."
    // 
    /// https://leetcode.com/problems/reverse-integer/
    /// </summary>
    public class Problem7ReverseInteger
    {
        /// <summary>
        /// There are two approaches I can think of for this problem:
        /// 
        /// 1 - String approach: convert int to string, reverse, done.
        /// 2 - Modulo approach: Use modulo 10 division and reverse one digit at
        /// a time.
        ///
        /// This solution uses the String approach.
        /// 
        /// Runtime complexity: O(n)
        /// </summary>
        public int Reverse(int x)
        {
            bool negative = x < 0;
            if (negative) x *= -1;

            string reversed = ReverseString(x.ToString());
            if (negative) reversed = "-" + reversed;

            int parsedInt = 0;
            bool isParsed = int.TryParse(reversed, out parsedInt);
            if (!isParsed) return 0;
            return parsedInt;
        }
        /// <summary>
        /// Reverses a string 
        /// </summary>
        private string ReverseString(string s)
        {
            string ans = "";

            // manually reverse it
            for(int i = s.Length-1; i >= 0; i--)
            {
                // consider using StringBuilder here. Currently, this wastefully
                // creates an entirely new String every time a new character is added
                ans += s[i];
            }
            return ans;
        }
    }
}
