using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        double[] ratios = MakeRatio(arr);
        foreach (double dec in ratios) {
            Console.WriteLine(dec);
        }
    }
    
    static double[] MakeRatio(int[] arr) {
        int n = arr.Length;
        int[] signCount = new int[3] {0, 0, 0};
        foreach (int number in arr) {
            signCount[Math.Sign(number)+1]++;
        }
        return new double[3] {(double)signCount[2]/n, (double)signCount[0]/n, (double)signCount[1]/n};
    }
}
