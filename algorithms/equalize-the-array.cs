using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Int32.Parse(Console.ReadLine());
        string[] atemp = Console.ReadLine().Split(' ');
        int[] array = Array.ConvertAll(atemp, Int32.Parse);
        Console.WriteLine(MinDel(n, array));
    }
    
    static int MinDel(int n, int[] array) {
        int[] counts = new int[100];
        foreach (int m in array) {
            counts[m-1]++;
        }
        int max = 0;
        foreach (int m in counts) {
            max = Math.Max(m,max);
        }
        return n-max;
    }
}