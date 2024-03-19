using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int[] counts = new int[26]; // Array to store counts of tasks
        foreach (char task in tasks) {
            counts[task - 'A']++; // Increment count for the corresponding task
        }
        
        Array.Sort(counts); // Sort counts in ascending order
        
        int maxCount = counts[25]; // Get the count of the most frequent task
        int idleSlots = (maxCount - 1) * n; // Calculate the maximum possible idle slots
        
        for (int i = 24; i >= 0 && counts[i] > 0; i--) {
            idleSlots -= Math.Min(counts[i], maxCount - 1); // Subtract the actual number of idle slots required
        }
        
        return Math.Max(0, idleSlots) + tasks.Length; // Return total intervals needed
    }
}
