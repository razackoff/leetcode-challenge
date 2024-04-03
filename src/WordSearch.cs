public class Solution {
    public bool Exist(char[][] board, string word) {
        for(int i = 0; i < board.Length; i++){
            for(int j = 0; j < board[i].Length; j++){
                if(board[i][j] == word[0]){
                    if(dfs(board, word, 0, i, j)){
                        return true;
                    }
                }
            }
        }
        return false;
    }

    private bool dfs(char[][] board, string word, int index, int x, int y){
        if(index == word.Length){
            return true;
        }
        if(x < 0 || x >= board.Length || y < 0 || y >= board[0].Length || board[x][y] != word[index]){
            return false;
        }
        
        char temp = board[x][y];
        board[x][y] = ' '; // Mark as visited
        
        bool found = dfs(board, word, index + 1, x + 1, y) ||
                     dfs(board, word, index + 1, x - 1, y) ||
                     dfs(board, word, index + 1, x, y + 1) ||
                     dfs(board, word, index + 1, x, y - 1);
        
        board[x][y] = temp; // Revert back to original character
        
        return found;
    }
}
