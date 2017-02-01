using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string[] array = Console.ReadLine().Split(' ');
        int R = Int32.Parse(array[0]);
        int C = Int32.Parse(array[1]);
        long N = Int64.Parse(array[2]);
        char[][] board = new char[R][];
        for (int row = 0; row < R; row++) {
            board[row] = Console.ReadLine().ToCharArray();
        }
        Console.Write(BoardState(R, C, N, board));
    }
    
    static string BoardState(int R, int C, long N, char[][] board) {
        if (N != 1) {
            for (int i = 0; i < R; i++) {
                for (int j = 0; j < C; j++) {
                    if (board[i][j] == '.') {
                        if (!(
                        (i > 0 && board[i-1][j] == 'O')
                        || (i < R-1 && board[i+1][j] == 'O')
                        || (j > 0 && board[i][j-1] == 'O')
                        || (j < C-1 && board[i][j+1] == 'O')
                        )) {
                            board[i][j] = 'i';
                        }
                        else {
                            board[i][j] = 'b';
                        }
                    }
                }
            }
            for (int i = 0; i < R; i++) {
                for (int j = 0; j < C; j++) {
                    if (board[i][j] == 'b'
                        && !(
                        (i > 0 && board[i-1][j] == 'i')
                        || (i < R-1 && board[i+1][j] == 'i')
                        || (j > 0 && board[i][j-1] == 'i')
                        || (j < C-1 && board[i][j+1] == 'i')
                        )) {
                        board[i][j] = 'O';
                    }
                }
            }
        }
        
        string output = "";
        for (int i = 0; i < R; i++) {
            for (int j = 0; j < C; j++) {
                if (N % 2 == 0
                	|| (N % 4 == 1 && board[i][j] == 'O')
                	|| (N % 4 == 3 && (board[i][j] == 'i')
                	)) {
                    output += "O";
                }
                else {
                    output += ".";
                }
            }
            output += "\n";
        }
        return output;
    }
}