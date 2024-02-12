public class Solution {
    public string GetPermutation(int n, int k) {
        List<int> nums = new List<int>();
        int i = 0, j = 0;
        for(i = 1; i <= n; i++){
            nums.Add(i);
        }
        for(int d = 1; d < k; d++){
            i = nums.Count - 2;
            while (i >= 0 && nums[i + 1] <= nums[i]) {
                i--;
            }
            if (i >= 0) {
                j = nums.Count - 1;
                while (nums[j] <= nums[i]) {
                    j--;
                }
                swap(nums, i, j);
            }
            reverse(nums, i + 1);
        }
        string s = "";
        for(i = 0; i < nums.Count; i++){
            s += nums[i].ToString();
        }
        return s;
    }
    private void reverse(List<int> nums, int start) {
        int i = start, j = nums.Count - 1;
        while (i < j) {
            swap(nums, i, j);
            i++;
            j--;
        }
    }
    private void swap(List<int> nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}