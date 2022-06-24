using System;
using LeetCode.Solutions.Cs.Problem771JewelsAndStones;
using LeetCode.Solutions.Cs.Problem9PalindromeNumber;
using Xunit;

namespace LeetCode.Tests
{
    public class Problem771JewelsAndStonesTest
    {
        public Problem771JewelsAndStonesTest()
        {

        }
        Problem771JewelsAndStones solver = new Problem771JewelsAndStones();

        /// <summary>
        /// Normal test case (base case)
        /// </summary>
        [Fact]
        public void BaseCaseTest()
        {
            // Arrange & Act
            string jewels = "aA";
            string stones = "aAAbbbb";

            var answer = solver.NumJewelsInStones(jewels, stones);

            // Assert
            Assert.Equal(3, answer);
        }
        /// <summary>
        /// Normal test case (base case)
        /// </summary>
        [Fact]
        public void BaseCaseTest2()
        {
            // Arrange & Act
            string jewels = "z";
            string stones = "ZZ";

            var answer = solver.NumJewelsInStones(jewels, stones);

            // Assert
            Assert.Equal(0, answer);
        }
    }
}
