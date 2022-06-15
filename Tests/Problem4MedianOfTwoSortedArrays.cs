using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Solutions.Cs.Problem4MedianOfTwoSortedArrays;
using Xunit;

namespace LeetCode.Tests
{
    public class Problem4MedianOfTwoSortedArraysTest
    {
        private Problem4MedianOfTwoSortedArrays solver = new Problem4MedianOfTwoSortedArrays();

        /// <summary>
        /// Normal test case (base case)
        /// </summary>
        [Fact]
        public void BaseCase()
        {
            // Arrange & Act
            int[] input1 = { 1, 3 };
            int[] input2 = { 2 };
            var answer = solver.FindMedianSortedArrays(input1, input2);

            // Assert
            Assert.Equal(2, answer);
        }
        [Fact]
        public void Test1()
        {
            // Arrange & Act
            int[] input1 = { 1, 2 };
            int[] input2 = { 3, 4 };
            var answer = solver.FindMedianSortedArrays(input1, input2);

            // Assert
            Assert.Equal(2.5d, answer);
        }
    }
}
