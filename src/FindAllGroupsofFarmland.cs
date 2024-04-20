public class Solution {
    public int[][] FindFarmland(int[][] land) {
        List<int[]> result = new List<int[]>();

        int rows = land.Length;
        int cols = land[0].Length;

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (land[i][j] == 1) {
                    int[] coordinates = DFS(land, i, j);
                    result.Add(coordinates);
                }
            }
        }

        return result.ToArray();
    }

    private int[] DFS(int[][] land, int row, int col) {
        int rows = land.Length;
        int cols = land[0].Length;

        // Find the bottom right corner of the farmland
        int r2 = row;
        int c2 = col;
        while (r2 + 1 < rows && land[r2 + 1][col] == 1) {
            r2++;
        }
        while (c2 + 1 < cols && land[row][c2 + 1] == 1) {
            c2++;
        }

        // Mark the visited farmland as 0
        for (int i = row; i <= r2; i++) {
            for (int j = col; j <= c2; j++) {
                land[i][j] = 0;
            }
        }

        return new int[] { row, col, r2, c2 };
    }
}