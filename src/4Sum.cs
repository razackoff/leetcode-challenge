public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 3; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) continue; // Skip duplicate values
            for (int j = i + 1; j < nums.Length - 2; j++) {
                if (j > i + 1 && nums[j] == nums[j - 1]) continue; // Skip duplicate values
                int left = j + 1;
                int right = nums.Length - 1;
                while (left < right) {
                    long sum = (long)nums[i] + nums[j] + nums[left] + nums[right]; // Cast to long
                    if (sum == target) {
                        result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                        while (left < right && nums[left] == nums[left + 1]) left++; // Skip duplicate values
                        while (left < right && nums[right] == nums[right - 1]) right--; // Skip duplicate values
                        left++;
                        right--;
                    } else if (sum < target) {
                        left++;
                    } else {
                        right--;
                    }
                }
            }
        }
        return result;
    }
}
