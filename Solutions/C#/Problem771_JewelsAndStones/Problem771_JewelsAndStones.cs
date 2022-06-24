using System;
namespace LeetCode.Solutions.Cs.Problem771JewelsAndStones
{
    /// <summary>
    /// Problem # 771
    /// "You're given strings jewels representing the types of stones that are
    /// jewels, and stones representing the stones you have. Each character in
    /// stones is a type of stone you have. You want to know how many of the
    /// stones you have are also jewels.
    /// 
    /// Letters are case sensitive, so "a" is considered a different type of
    /// stone from "A"."
    // 
    /// https://leetcode.com/problems/jewels-and-stones/
    /// </summary>
    public class Problem771JewelsAndStones
    {
        /// <summary>
        /// Runtime complexity: O(n**2)
        /// </summary>
        public int NumJewelsInStones(string jewels, string stones)
        {

            int result = 0;
            foreach (char jewel in jewels)
            {
                foreach (char stone in stones)
                {
                    if (jewel == stone) { result++; }
                }
            }
            return result;
        }
    }
}
