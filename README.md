# LeetCode solutions

- [About this repository](#about-this-repository)
- [Solutions](#solutions)
- [Tests](#tests)
- [Naming Conventions](#naming-conventions)
- [To-Do](#to-do)

## About this repository

This is a repository for my solutions to [LeetCode](https://leetcode.com/) problems, written in python and C#.
Some (or all) of these solutions may be sub-optimal.

[Unit tests](https://en.wikipedia.org/wiki/Unit_testing) for C# solutions were made using [xUnit](https://xunit.net/).

## Solutions

| Problem | Solution(s) | xUnit Test |
|---------|-------------|------------|
| #1 [Two Sum](https://leetcode.com/problems/two-sum/) | [C#](https://github.com/TheFernandoM/LeetCode/blob/main/Solutions/C%23/Problem1_TwoSum/Problem1_TwoSum.cs), [python](https://github.com/TheFernandoM/LeetCode/blob/main/Solutions/python/Problem1_TwoSum/two_sum.py)|[link](https://github.com/TheFernandoM/LeetCode/blob/main/Tests/Problem1_TwoSumTest.cs)|
| #3 [Length of Longest Substring](https://leetcode.com/problems/longest-substring-without-repeating-characters/) | [C#](https://github.com/TheFernandoM/LeetCode/blob/main/Solutions/C%23/Problem3_LongestSubstring/Problem3_LengthOfLongestSubstring.cs)|[link](https://github.com/TheFernandoM/LeetCode/blob/main/Tests/Problem3_LengthOfLongestSubstringTest.cs)|
| #4 [Median of Two Sorted Arrays](https://leetcode.com/problems/median-of-two-sorted-arrays/) | [C#](https://github.com/TheFernandoM/LeetCode/blob/main/Solutions/C%23/Problem4_MedianOfTwoSortedArrays/Problem4_MedianOfTwoSortedArrays.cs)|[link](https://github.com/TheFernandoM/LeetCode/blob/main/Tests/Problem4_MedianOfTwoSortedArraysTest.cs)|
| #7 [Reverse Integer](https://leetcode.com/problems/reverse-integer/) | [C#](https://github.com/TheFernandoM/LeetCode/blob/main/Solutions/C%23/Problem7_ReverseInteger/Problem7_ReverseInteger.cs)|[link](https://github.com/TheFernandoM/LeetCode/blob/main/Tests/Problem7_ReverseIntegerTest.cs)|
| #9 [Palindrome Number](https://leetcode.com/problems/palindrome-number/) | [C#](https://github.com/TheFernandoM/LeetCode/blob/main/Solutions/C%23/Problem9_PalindromeNumber/Problem9_PalindromeNumber.cs) | [link](https://github.com/TheFernandoM/LeetCode/blob/main/Tests/Problem9_PalindromeNumberTest.cs)|
| #21 [Merge Two Sorted Lists](https://leetcode.com/problems/merge-two-sorted-lists/) | [C#](https://github.com/TheFernandoM/LeetCode/blob/main/Solutions/C%23/Problem21_MergeTwoSortedLists/Problem21_MergeTwoSortedLists.cs) | [link](https://github.com/TheFernandoM/LeetCode/blob/main/Tests/Problem21_MergeTwoSortedListsTest.cs)|
| #27 [Remove Element](https://leetcode.com/problems/remove-element/) | [C#](https://github.com/TheFernandoM/LeetCode/blob/main/Solutions/C%23/Problem27_RemoveElement/Problem27_RemoveElement.cs) | [link](https://github.com/TheFernandoM/LeetCode/blob/main/Tests/Problem27_RemoveElementTest.cs)|

## Tests
Unit tests can be executed by using the command `dotnet test` from a terminal while in the repository directory (must have `.NET` and `xUnit` installed).
They can also be executed from Visual Studio (Run -> Run Unit Tests).

In this project, unit tests are used for: verifying answers, checking corner cases, and confirming that the solutions still work even after the code implementation has been modified. Writing unit tests helps with the process of thinking up solutions to the problems.

LeetCode does not provide any test cases unless the user-provided solution fails that particular test case, so it is up to the author to devise most corner cases when they are not provided.

## Naming Conventions

The reason for having an underscore `_` in file/folder names is to make it easier at a glance to read the problem number and problem name. Having one folder per problem allows for having multiple solution implementations in a grouped location. It is also done for the sake of cleanliness and having consistent structure

* Folder names:
    * `<programming language>/<Problem#_ProblemName>`. Example: `C#/Problem1_TwoSum`.

* File names:
    *  `<Problem#_ProblemName>.<file extension>`. Example: `Problem1_TwoSum.cs`.

* Namespaces:
    * Even though folders/files contains underscores `_`, namespaces do not contain dashes or underscores because of the problems doing so can cause.
    * Namespaces are currently named by hand since by default Visual Studio tries to add an underscore in the name, and because special characters in filenames are ignored when generating a namespace (I.e. the folder `C#` in a namespace becomes `C`. This has to manually be renamed to `Cs`)

## To-Do
* Create a script (bash or python) to automatically generate the files and folders necessary to add a new problem to the repository, as well as automatically update this README file. It is tedious and inefficient to update this README by hand.

* Rename the files and folders with a fixed number of zeroes (0) in their name. This will sort the files/folders in numeric order
    * Currently, the files with numbers `2*`,`2**`, `2***` (and so on...) are ordered before `3` even though they are larger numbers. Exaple: `27` is orderd before `5`, even though it is larger.

    * The fix is to add padding with a fixed number of zeroes, for example: `25` becomes `000025`. In this way, a smaller number such as `000003` will be ordered before a bigger number, for example `000027`.
    * As of the time of writing, there are `2310` problems on LeetCode. If the fixed padding is 4 digits, the maximum value would be `9999`. To future proof this convention of using a fixed padding, it is preferable to use 5 digits, which allows for `99 999` problems to be added. This is far than the number of problems that will be realistically in the foreseeable future (years). 

* Consider creating one folder per Test, similar to how each Solution to a Problem has its own folder.

* Add Continous Integration/Continuous Deployment (CD/CI) through GitHub, to automatically run tests with every change that is made to the codebase.
