public class Solution {
    public int[] SortedSquares(int[] nums) {
        int left = 0, right = nums.Length - 1, i = nums.Length - 1;
        int[] output = new int[nums.Length];
        
        while (left <= right) {
            int value;
            if (nums[left] * nums[left] >= nums[right] * nums[right]) {
                value = nums[left] * nums[left++];
            } else {
                value = nums[right] * nums[right--];
            }
            output[i--] = value;
        }
        return output;
    }
}