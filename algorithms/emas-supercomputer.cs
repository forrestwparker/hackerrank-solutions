using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string[] size_temp = Console.ReadLine().Split(' ');
        int[] size = Array.ConvertAll(size_temp, Int32.Parse);
        char[][] board = new char[size[0]][];
        for (int row = 0; row < size[0]; row++) {
            board[row] = Console.ReadLine().ToCharArray();
        }
        Console.Write(FindPlusProduct(size, board));
    }
    
    static int FindPlusProduct(int[] size, char[][] board) {
        int maxProduct = 0;
        for (int a = 0; a < size[0]*size[1]-1; a++) {
            int acol = a % size[1];
            int arow = (int)((a-acol)/size[1]);
            if (board[arow][acol] == 'G') {
                int arad = 0;
                while (CheckRad(size, board, arow, acol, arad)) {
                    for (int b = a+1; b < size[0]*size[1]; b++) {
                        int bcol = b % size[1];
                        int brow = (int)((b-bcol)/size[1]);
                        if (board[brow][bcol] == 'G') {
                            int brad = 0;
                            while (CheckRad(size, board, brow, bcol, brad) && CheckIntersect(arow, acol, arad, brow, bcol, brad)) {
                                maxProduct = Math.Max(maxProduct, (4*arad+1)*(4*brad+1));
                                brad++;
                            }
                        }
                    }
                    arad++;
                }
            }
        }
        return maxProduct;
    }
    
    static bool CheckRad(int[] size, char[][] board, int row, int col, int rad) {
        if (row-rad >= 0
           && row+rad < size[0]
           && col-rad >= 0
           && col+rad < size[1]
           && board[row-rad][col] == 'G'
           && board[row+rad][col] == 'G'
           && board[row][col-rad] == 'G'
           && board[row][col+rad] == 'G') {
            return true;
        }
        else {
            return false;
        }
    }
    
    static bool CheckIntersect(int arow, int acol, int arad, int brow, int bcol, int brad) {
        int rowdiff = Math.Abs(arow-brow);
        int coldiff = Math.Abs(acol-bcol);
        if (Math.Min(rowdiff, coldiff) == 0 && Math.Max(rowdiff, coldiff) <= arad+brad) {
            return false;
        }
        else if ((Math.Abs(arow-brow) <= arad && Math.Abs(acol-bcol) <= brad)
            || Math.Abs(arow-brow) <= brad && Math.Abs(acol-bcol) <= arad) {
            return false;
        }
        else {
            return true;
        }
    }
}