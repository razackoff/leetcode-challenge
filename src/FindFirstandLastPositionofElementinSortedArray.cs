public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int startPosition = -1, endPosition = -1;
        for(int i = 0; i < nums.Length; i++){
            if(target == nums[i]){
                if(startPosition == -1){
                    startPosition = i;
                    endPosition = i;
                }
                else{
                    endPosition = i;
                }
            }
        }
        return new int[] {startPosition, endPosition};
    }
}