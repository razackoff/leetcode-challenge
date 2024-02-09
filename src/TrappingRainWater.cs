public class Solution {
    public int Trap(int[] height) {
        int left = 0, right = 0, min = 0, ans = 0, list = 0, flag = 0;
        for(int i = 0; i  < height.Length; i++){
            if(height[i] >= height[left]){
                right = i;
                if(flag != 0){
                    if(height[left] >= height[right]){
                        min = height[right];
                    }
                    else{
                        min = height[left];
                    }
                    for(int j = left + 1; j < right; j++){
                        ans = ans + (min - height[j]);
                    }
                }
                left = right;
                flag = 1;
            }
        }
        right = height.Length - 1;
        int remain = 0, lleft = right;
        for(int i = height.Length - 1; i >= left; i--){
             if(height[i] >= height[right]){
                list = list * 10;
                list = list + i;
                lleft = i;
                if(height[lleft] >= height[right]){
                    min = height[right];
                }
                else{
                    min = height[lleft];
                }
                for(int j = lleft + 1; j < right; j++){
                    remain = remain + (min - height[j]);
                }
                right = lleft;
            }
        }
        ans += remain;
        return ans;
    }
}