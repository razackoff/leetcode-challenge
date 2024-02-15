public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        List<IList<int>> result = new List<IList<int>>();
        Search(candidates, target, 0, 0, new List<int>(), result);
        return result;
    }

    private void Search(int[] nums, int target, int index, int sum, IList<int> temp, IList<IList<int>> result){
        if(sum == target){
            result.Add(temp.ToArray());
            return;
        }

        while(sum < target && index < nums.Length){
            temp.Add(nums[index]);

            Search(nums, target, index, sum + nums[index], temp, result);

            temp.RemoveAt(temp.Count - 1);
            index++;
        }
    }
}