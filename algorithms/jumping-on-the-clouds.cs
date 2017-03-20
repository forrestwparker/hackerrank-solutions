using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp,Int32.Parse);
        Console.WriteLine(Jump(n, c));
    }
    
    static int Jump(int n, int[] c) {
        int pos = 0;
        int count = 0;
        while (pos < n-1) {
            if (pos+2 >= n-1 || c[pos+2] == 0) {
                pos += 2;
                count++;
            }
            else {
                pos += 3;
                count += 2;
            }
        }
        return count;
    }
}