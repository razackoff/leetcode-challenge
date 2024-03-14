public class Solution {
    public int NumSubarraysWithSum(int[] nums, int goal) {
        int ans = 0, sum = 0;
        for(int i = 0; i < nums.Length; i++){
            sum = nums[i];
            if(sum == goal) ans++;
            for(int j = i + 1; j < nums.Length; j++){
                sum += nums[j];
                if(sum == goal) ans++;
            }
        }
        return ans;
    }
}