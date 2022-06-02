using System;
namespace LeetCode.Solutions.Cs.Problem9PalindromeNumber
{
    public class Problem9PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {

            if (x < 0) { return false; }
            if (x < 10) { return true; }
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
