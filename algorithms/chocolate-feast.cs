using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int c = Convert.ToInt32(tokens_n[1]);
            int m = Convert.ToInt32(tokens_n[2]);
            Console.WriteLine(Chocolate(n,c,m));
        }
    }
    
    static int Chocolate(int n, int c, int m) {
        int count = (int)Math.Floor((double)n/c);
        int wrappers = count;
        while (wrappers >= m) {
            int newchoc = (int)((wrappers - (wrappers % m))/m);
            count += newchoc;
            wrappers = (wrappers % m) + newchoc;
        }
        return count;
    }
}
