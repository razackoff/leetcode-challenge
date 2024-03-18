public class Solution {
    public int FindMinArrowShots(int[][] points) {
        if (points == null || points.Length == 0) return 0;

        // Sort the array based on the end point of each balloon
        Array.Sort(points, (x, y) => x[1].CompareTo(y[1]));

        int arrows = 1;
        int end = points[0][1];

        // Iterate through the sorted array and count arrows needed
        for (int i = 1; i < points.Length; i++) {
            // If the current balloon starts after the previous one ends, we need another arrow
            if (points[i][0] > end) {
                arrows++;
                end = points[i][1]; // Update the end point of the current balloon
            }
            // If the current balloon overlaps with the previous one, update the end point
            else {
                end = Math.Min(end, points[i][1]);
            }
        }

        return arrows;
    }
}