using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        char[][] a = new char[n][];
        for (int i = 0; i < n; i++) {
            a[i] = Console.ReadLine().ToCharArray();
        }
        Console.WriteLine(MarkCavities(n,a));
    }
    
    static string MarkCavities(int n, char[][] a) {
        string output = "";
        if (n >= 3) {
            for (int row = 1; row < n-1; row++) {
                for (int col = 1; col < n-1; col++) {
                    if (a[row-1][col] != 'X'
                        && a[row][col-1] != 'X'
                        && a[row][col] > a[row-1][col]
                        && a[row][col] > a[row][col+1]
                        && a[row][col] > a[row+1][col]
                        && a[row][col] > a[row][col-1]) {
                        a[row][col] = 'X';
                    }
                }
            }
        }
        for (int i = 0; i < n; i++) {
            output += (new string(a[i]))+"\n";
        }
        return output;
    }
}
