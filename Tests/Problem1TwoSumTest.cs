using System;
using LeetCode.Solutions.Cs.Problem1TwoSum;
using Xunit;

namespace LeetCode.Tests
{
    public class Problem1TwoSumTest
    {
        Problem1TwoSum solver = new Problem1TwoSum();

        /// <summary>
        /// Normal test case (base case)
        /// </summary>
        [Fact]
        public void BaseCase()
        {
            // Arrange & Act
            var answer = solver.TwoSum(new int[] { 2, 7, 11, 15 }, 9);

            // Assert
            Assert.Equal(new int[] { 0, 1 }, answer);
        }

        /// <summary>
        /// Edge case: empty array, should return 
        /// </summary>
        [Fact]
        public void EmptyArrayTest()
        {
            // Arrange & Act
            var answer = solver.TwoSum(new int[] { }, 1);

            // Assert
            Assert.Null(answer);
        }

        /// <summary>
        /// Edge case: negative numbers. Similar to normal case.
        /// </summary>
        [Fact]
        public void NegativeNumbersTest()
        {
            // Arrange  
            var answer = solver.TwoSum(new int[] { -2, -7, -11, -15 }, -26);

            // Assert
            Assert.Equal(new int[] { 2, 3 }, answer);
        }
        /// <summary>
        /// Edge case: array contains only zeroes. Similar to normal case.
        /// </summary>
        [Fact]
        public void ZeroArrayTest()
        {
            // Arrange & Act
            var answer = solver.TwoSum(new int[] { 0, 0, 0, 0 }, 0);

            // the answer can be any two ints from the array (they're all 0 anyway)
            // soo..we just check to see if the array has 2 entries
            Assert.True(answer.Length == 2);
        }
    }
}

