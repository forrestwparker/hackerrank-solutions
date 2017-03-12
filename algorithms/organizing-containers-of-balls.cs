using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] M = new int[n][];
            for(int M_i = 0; M_i < n; M_i++){
               string[] M_temp = Console.ReadLine().Split(' ');
               M[M_i] = Array.ConvertAll(M_temp,Int32.Parse);
            }
            BallSwap(n, M);
        }
    }
    
    static void BallSwap(int n, int[][] M) {
        long[] rowsums = new long[n];
        long[] colsums = new long[n];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                rowsums[i] += (long)M[i][j];
                colsums[j] += (long)M[i][j];
            }
        }
        Array.Sort(rowsums);
        Array.Sort(colsums);
        if (rowsums.SequenceEqual(colsums)) {
            Console.WriteLine("Possible");
        }
        else {
            Console.WriteLine("Impossible");
        }
    }
}