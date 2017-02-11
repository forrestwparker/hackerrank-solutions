using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int T = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < T; i++) {
            string[] temp = Console.ReadLine().Split(' ');
            int R = Int32.Parse(temp[0]);
            int C = Int32.Parse(temp[1]);
            int[][] Grid = new int[R][];
            for (int j = 0; j < R; j++) {
                Grid[j] = Console.ReadLine().ToCharArray().Select(x => Int32.Parse(x.ToString())).ToArray();
            }
            temp = Console.ReadLine().Split(' ');
            int r = Int32.Parse(temp[0]);
            int c = Int32.Parse(temp[1]);
            int[][] pattern = new int[r][];
            for (int j = 0; j < r; j++) {
                pattern[j] = Console.ReadLine().ToCharArray().Select(x => Int32.Parse(x.ToString())).ToArray();
            }
            Console.WriteLine(FindPattern(R,C,Grid,r,c,pattern));
        }
    }
    
    static string FindPattern(int R, int C, int[][] Grid, int r, int c, int[][] pattern) {
        string output = "NO";
        for (int i = 0; i <= R-r && output == "NO"; i++) {
            for (int j = 0; j <= C-c && output == "NO"; j++) {
                if (pattern[0][0] == Grid[i][j]) {
                    bool check = true;
                    for (int m = 0; m < r && check; m++) {
                        for (int n = 0; n < c && check; n++) {
                            if (Grid[i+m][j+n] != pattern[m][n]) {
                                check = false;
                            }
                        }
                    }
                    if (check) {
                        output = "YES";
                    }
                }
            }
        }
        return output;
    }
}
