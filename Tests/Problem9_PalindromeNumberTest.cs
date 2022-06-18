using System;
using LeetCode.Solutions.Cs.Problem9PalindromeNumber;
using Xunit;

namespace LeetCode.Tests
{
    public class Problem9PalindromeNumberTest
    {
        public Problem9PalindromeNumberTest()
        {

        }
        Problem9PalindromeNumber solver = new Problem9PalindromeNumber();

        /// <summary>
        /// Normal test case (base case)
        /// </summary>
        [Fact]
        public void BaseCaseTest()
        {
            // Arrange & Act
            var answer = solver.IsPalindrome(11211);

            // Assert
            Assert.True(answer);
        }
    }
}
