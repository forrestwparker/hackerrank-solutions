using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string[] atemp = Console.ReadLine().Split(' ');
        int[] nd = Array.ConvertAll(atemp, Int32.Parse);
        int n = nd[0];
        int d = nd[1];
        atemp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(atemp, Int32.Parse);
        Console.WriteLine(CountBT(n, d, a));
    }
    
    static int CountBT(int n, int d, int[] a) {
        int count = 0;
        for (int i = 0; i < n-2; i++) {
            for (int j = i+1; j < n-1; j++) {
                if (a[j]-a[i] == d) {
                    for (int k = j+1; k < n; k++) {
                        if (a[k]-a[j] == d) {
                            count++;
                        }
                    }
                }
            }
        }
        return count;
    }
}