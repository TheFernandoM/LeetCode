using LeetCode.Solutions.Cs.Problem3LengthOfLongestSubstring;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCode.Tests
{
    public class Problem3LengthOfLongestSubstringTest
    {
        Problem3LengthOfLongestSubstring solver = new Problem3LengthOfLongestSubstring();

        /// <summary>
        /// Normal test case (base case)
        /// </summary>
        [Fact]
        public void BaseCase()
        {
            // Arrange & Act
            string s = "abcabcbb";
            var answer = solver.LengthOfLongestSubstring(s);

            // Assert
            Assert.Equal(3, answer);
        }
        /// <summary>
        /// Another normal test case
        /// </summary>
        [Fact]
        public void Test1()
        {
            // Arrange & Act
            string s = "pwwkew";
            var answer = solver.LengthOfLongestSubstring(s);

            // Assert
            Assert.Equal(3, answer);
        }
        [Fact]
        public void Test2()
        {
            // Arrange & Act
            string s = "aab";
            var answer = solver.LengthOfLongestSubstring(s);

            // Assert
            Assert.Equal(2, answer);
        }
        [Fact]
        public void Test3()
        {
            // Arrange & Act
            string s = "dvdf";
            var answer = solver.LengthOfLongestSubstring(s);

            // Assert
            Assert.Equal(3, answer);
        }
    }
}
