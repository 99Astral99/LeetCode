public class Solution {

 public int[] SmallerNumbersThanCurrent(int[] nums) {
        List<int> numsSorted = new List<int>(nums);
        numsSorted.Sort();
        int[] output = new int[nums.Length];
        for(int i = 0; i < numsSorted.Count; i++)
        {
            output[i] = numsSorted.IndexOf(nums[i]);
        }
        return output;
    }
}