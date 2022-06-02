'''
Author: Fernando Molina

Brute force solution.
Runtime is O(n ** 2) since there are two loops, and they are nested.
'''
class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        for i in range(0, len(nums)):
            for j in range(i+1, len(nums)):
                if(nums[i] + nums[j] == target):
                    return [i, j]
        return None