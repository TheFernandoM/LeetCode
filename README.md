# LeetCode solutions

- [About this repository](#about-this-repository)
- [Solutions](#solutions)
- [Tests](#tests)
- [To-Do](#to-do)

## About this repository

This is a repository for my solutions to [LeetCode](https://leetcode.com/) problems, written in python and C#.
Some (or all) of these solutions may be sub-optimal.

Unit tests for C# solutions were done using [xUnit](https://xunit.net/).

Files and folders are numerically unordered since GitHub uses ASCIIbetical order (compares only one digit at a time rather than all the digits in a number, for example: `27`, `270`, `2700` will ordered before `3`)

## Solutions

| Problem | Solution(s) | xUnit Test |
|---------|-------------|------------|
| #1 [Two Sum](https://leetcode.com/problems/two-sum/) | [C#](https://github.com/TheFernandoM/LeetCode/blob/main/Solutions/C%23/Problem1_TwoSum/Problem1TwoSum.cs), [python](https://github.com/TheFernandoM/LeetCode/blob/main/Solutions/python/Problem1_TwoSum/two_sum.py)|[link](https://github.com/TheFernandoM/LeetCode/blob/main/Tests/Problem1TwoSumTest.cs)|
| #3 [Length of Longest Substring](https://leetcode.com/problems/longest-substring-without-repeating-characters/) | [C#](https://github.com/TheFernandoM/LeetCode/blob/main/Solutions/C%23/Problem3_LongestSubstring/Problem3LengthOfLongestSubstring.cs)|[link](https://github.com/TheFernandoM/LeetCode/blob/main/Tests/Problem3LengthOfLongestSubstringTest.cs)|
| #4 [Median of Two Sorted Arrays](https://leetcode.com/problems/median-of-two-sorted-arrays/) | [C#](https://github.com/TheFernandoM/LeetCode/blob/main/Solutions/C%23/Problem4_MedianOfTwoSortedArrays/Problem4MedianOfTwoSortedArrays.cs)|[link](https://github.com/TheFernandoM/LeetCode/blob/main/Tests/Problem4MedianOfTwoSortedArrays.cs)|
| #9 [Palindrome Number](https://leetcode.com/problems/palindrome-number/) | [C#](https://github.com/TheFernandoM/LeetCode/blob/main/Solutions/C%23/Problem9_PalindromeNumber/Problem9PalindromeNumber.cs) | [link](https://github.com/TheFernandoM/LeetCode/blob/main/Tests/Problem9PalindromeNumberTest.cs)|
| #27 [Remove Element](https://leetcode.com/problems/remove-element/) | [C#](https://github.com/TheFernandoM/LeetCode/blob/main/Solutions/C%23/Problem27_RemoveElement/Problem27_RemoveElement.cs) | [link](https://github.com/TheFernandoM/LeetCode/blob/main/Tests/Problem27_RemoveElementTest.cs)|

## Tests
Tests can be executed by using the command `dotnet test` from a terminal while in the repository directory (must have `.NET` and `xUnit` installed).
They can also be executed from Visual Studio (Run -> Run Unit Tests).

The tests are used to verify answers, check corner cases, and confirm that the solutions still work even after the code has been modified. Writing unit tests helps with thinking of solutions to the problems.

LeetCode does not provide any test cases unless the user-provided solution fails that particular test case, so it is up to the author to devise most corner cases when they are not provided.

## To-Do
* Create a script (bash or python) to automatically generate the files and folders necessary to add a new problem to the repository. It gets tedious updating this README file by hand.
