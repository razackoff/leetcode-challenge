public class Solution {
    public int MaxSubarrayLength(int[] nums, int k) {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        int ans = Int32.MinValue;
        for(int i = 0, j = 0; j < nums.Length; j ++){
            if(!dictionary.ContainsKey(nums[j]))
                dictionary.Add(nums[j], 1);
            else
                dictionary[nums[j]] ++;
            
            if(dictionary[nums[j]] > k){
                while(dictionary[nums[j]] > k){
                    dictionary[nums[i]] --;
                    i ++;
                }
            }
            ans = Math.Max(ans, j - i + 1);
        }
        return ans;
    }
}