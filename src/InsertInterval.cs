public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        if (intervals.Length == 0)
            return new int[][] { newInterval };

        var result = new List<int[]>();

        int i = 0;
        // skip all intervals the come before the newInterval
        // curEnd = intervals[i][1]
        // newStart = newInterval[0]
        while (i < intervals.Length && intervals[i][1] < newInterval[0])
        {
            result.Add(intervals[i]);
            i++;
        }

        // merge all intervals that overlap with newInterval
        // curStart = intervals[i][0]
        // newEnd = newInterval[1]
        while (i < intervals.Length && intervals[i][0] <= newInterval[1])
        {
            newInterval[0] = Math.Min(newInterval[0], intervals[i][0]); // start
            newInterval[1] = Math.Max(newInterval[1], intervals[i][1]); // end
            i++;
        }

        result.Add(newInterval);

        // add all remaining intervals
        while (i < intervals.Length)
        {
            result.Add(intervals[i]);
            i++;
        }

        return result.ToArray();
    }
}