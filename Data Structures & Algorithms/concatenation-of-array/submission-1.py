class Solution:
    def getConcatenation(self, nums: List[int]) -> List[int]:
        ans = []
        #run the loop twice as we have to concatenate the nums
        for i in range(2):
            for num in nums:
                ans.append(num)
        return ans
             

