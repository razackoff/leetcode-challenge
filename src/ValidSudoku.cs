public class Solution {
    public bool IsValidSudoku(char[][] board) {
        //Time - O(n) as we traverse entire array twice
        //Space - O(1)

        //First going through entire rows and columns
        for(int i=0; i<board.Length; i++){
            HashSet<int> rowRecords = new HashSet<int>();
            HashSet<int> colRecords = new HashSet<int>();
            for(int j=0; j< board[0].Length; j++){
                if(board[i][j] != '.'){
                    if(rowRecords.Contains(board[i][j])) return false;
                    rowRecords.Add(board[i][j]);
                }
                if(board[j][i] != '.'){
                    if(colRecords.Contains(board[j][i])) return false;
                    colRecords.Add(board[j][i]);
                }
            }
        }
        
        //Checking each 3x3 square for duplicates
        for(int i=0; i<board.Length; i++){
            for(int j=0; j<board[0].Length; j++){
                HashSet<int> sqRecords = new HashSet<int>();
                for(int m=i; m<i+3; m++){
                    for(int n=j; n<j+3; n++){
                        if(board[m][n] == '.') continue;
                        if(sqRecords.Contains(board[m][n])) return false;
                        sqRecords.Add(board[m][n]);
                    }
                }
                j += 2;
            }
            i += 2;
        }

        return true;
    }
}