using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int p = Int32.Parse(Console.ReadLine());
        int q = Int32.Parse(Console.ReadLine());
        Console.WriteLine(KPR(p,q));
    }
    
    static string KPR(int p, int q) {
        string output = "";
        for (int n = p; n <= q; n++) {
            int d = n.ToString().Length;
            string square = Math.Pow(n,2).ToString();
            int len = square.Length;
            int r = Int32.Parse(square.Substring(len-d,d));
            int l = 0;
            if (len-d != 0) {
                l = Int32.Parse(square.Substring(0,len-d));
            }
            if (l+r == n) {
                output += n.ToString()+" ";
            }
        }
        if (output.Length == 0) {
            output = "INVALID RANGE";
        }
        return output;
    }
}