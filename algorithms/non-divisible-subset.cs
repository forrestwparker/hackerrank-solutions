using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string[] atemp = Console.ReadLine().Split(' ');
        int[] array = Array.ConvertAll(atemp, Int32.Parse);
        int n = array[0];
        int k = array[1];
        atemp = Console.ReadLine().Split(' ');
        array = Array.ConvertAll(atemp, Int32.Parse);
        Console.WriteLine(MaxArray(n,k,array));
    }
    
    static int MaxArray(int n, int k, int[] array) {
        int[] counts = new int[k];
        int total = 0;
        foreach (int a in array) {
            counts[a%k]++;
        }
        if (counts[0] > 0) {
            total++;
        }
        if (k % 2 == 0 && counts[k/2] > 0) {
                total++;
        }
        for (int i = 1; i < (int)Math.Ceiling((double)k/2); i++) {
            total += Math.Max(counts[i], counts[k-i]);
        }
        string s = "";
        foreach (int i in counts) {
            s += i.ToString()+" ";
        }
        return total;
    }
}