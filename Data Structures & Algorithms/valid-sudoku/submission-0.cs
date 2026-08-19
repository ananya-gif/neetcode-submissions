public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var boxes = new HashSet<char>[9];
        for(int i = 0; i < 9; i++){
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int row = 0; row < 9; row++){
            for(int col = 0; col < 9; col++){
                char value = board[row][col];
                if(value == '.'){
                    continue;
                }
                int box = (row / 3) * 3 + (col / 3);
                if(rows[row].Contains(value)||cols[col].Contains(value)||boxes[box].Contains(value)){
                    return false;
                }

                rows[row].Add(value);
                cols[col].Add(value);
                boxes[box].Add(value);
            }
        }
        return true;
    }
}
