public class Solution {
    public void Rotate(int[][] matrix) {
        List<int> list = new();
        for(int i = 0; i < matrix.Length; i++){
            for(int j = matrix.Length - 1; j >= 0; j--){
                //matrix[i][j] = matrix[1][0];
                list.Add(matrix[j][i]);
            }    
        }
        int k = 0, v = 0, h = 0;
        for(int i = 0; i < list.Count; i++){
            if(h == matrix.Length){
                h = 0;
                v++;
            }
            matrix[v][h] = list[i];
            k++;
            h++;
        }
    }
}