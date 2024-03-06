public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        var smaller = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            smaller[i] = nums.Where(x => x < nums[i]).Count();
        }

        return smaller;
    }
}