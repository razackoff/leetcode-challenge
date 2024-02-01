class Solution {
    fun search(nums: IntArray, target: Int): Int {
        var index = 1
        var targetIndex = -1
        if(nums[0] == target){
            return 0
        }
        while(index < nums.size){
            if(target == nums[index]){
                return index
            }
            index = index + 1
        }
        return -1
    }
}