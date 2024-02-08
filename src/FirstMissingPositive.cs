public class Solution {
    public int FirstMissingPositive(int[] nums) {
        List<int> used = new List<int>();
        for(int i = 0; i < 100005; i++){
            used.Add(0);
        }
        //used.EnsureCapacity(100);
        //return used.Count;
        int max = 1;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] > max && nums[i] < 100010){
                max = nums[i];
            }
            if(nums[i] > 0 && nums[i] < 100010){
                used[nums[i]] = 1;
            }
        }
        for(int i = 1; i <= max + 1; i++){
            if(used[i] == 0){
                return i;
            }
        }
        return 1;
    }
}