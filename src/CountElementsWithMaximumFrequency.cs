public class Solution {
    public int MaxFrequencyElements(int[] nums) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int max = 0, count = 0;
        foreach(int num in nums) {
            if(!map.ContainsKey(num))
                map[num] = 0;
            map[num]++;
            if(max < map[num]) {
                max = map[num];
                count = 0;
            }
            if(max == map[num])
                count++;
        }

        return count * max;
    }
}