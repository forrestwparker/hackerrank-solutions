using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }
        int diff = MakeDifference(a);
        Console.Write(diff);
    }
    
    static int MakeDifference(int[][] arr) {
        int[] diagSums = new int[2] {0, 0};
        int n = arr.Length;
        for (int rcindex = 0; rcindex < n; rcindex++) {
            diagSums[0] += arr[rcindex][rcindex];
            diagSums[1] += arr[rcindex][n-rcindex-1];
        }
        return Math.Abs(diagSums[0]-diagSums[1]);
    }
}
