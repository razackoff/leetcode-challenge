public class Solution {
    public int FindDuplicate(int[] nums)
    {
        var lenght = nums.Length;
        var buffer = new bool[lenght];
        foreach (var num in nums)
        {
            if (buffer[num - 1])
            {
                return num;
            }
            buffer[num - 1] = true;
        }
        return 0;
    }
}