public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int p1 = 1, p2 = 1, f1 = 0, f2 = 0;
        for(int i = 0; i < nums.Length / 2; i++){
            if(nums[i] == 0){
                f1++;
            }
            else{
                p1 *= nums[i];
            }
        }
        for(int i = nums.Length / 2; i < nums.Length; i++){
            if(nums[i] == 0){
                f2++;
            }
            else{
                p2 *= nums[i];
            }
        }
        /*nums[0] = p1;
        nums[1] = f1;
        nums[2] = p2;
        nums[3] = f2;*/
        for(int i = 0; i < nums.Length; i++){
            if((nums[i] == 0 && f1 + f2 > 1) || (nums[i] != 0 && f1 + f2 > 0)){
                nums[i] = 0;
            }
            else{
                if(nums[i] == 0){
                    nums[i] = p1 * p2;
                }
                else if(i < nums.Length / 2){
                    nums[i] = (p1 / nums[i]) * p2;

                }
                else{
                    nums[i] = p1 * (p2 / nums[i]);
                }
            }
        }
        return nums;
    }
}