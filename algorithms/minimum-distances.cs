using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] A_temp = Console.ReadLine().Split(' ');
        int[] A = Array.ConvertAll(A_temp,Int32.Parse);
        Console.WriteLine(MinD(n, A));
    }
    
    static int MinD(int n, int[] a) {
        int mind = -1;
        int v = 0;
        int zero = a[0];
        int[] p = new int[100000];
        for (int i = 1; i < n; i++) {
            if (p[a[i]] == 0) {
                p[a[i]] = i;
                if (a[i] == zero) {
                    mind = SetMind(mind, i, 0);
                }
            }
            else {
                mind = SetMind(mind, i, p[a[i]]);
                p[a[i]] = i;
            }
        }
        return mind;
    }
    
    static int SetMind(int mind, int i, int j) {
        if (mind == -1 || i-j < mind) {
            mind = i-j;
        }
        return mind;
    }
}
