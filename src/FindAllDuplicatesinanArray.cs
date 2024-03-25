public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        var lenght = nums.Length;
        List<int> ans = new();
        var buffer = new bool[lenght + 1];
        foreach (var num in nums)
        {
            if (buffer[num])
            {
                ans.Add(num);
            }
            else{
                buffer[num] = true;
            }
        }
        return ans;
    }
}