using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        string[] B_temp = Console.ReadLine().Split(' ');
        int[] B = Array.ConvertAll(B_temp,Int32.Parse);
        Console.WriteLine(Bread(N, B));
    }
    
    static string Bread(int n, int[] array) {
        int count = 0;
        int pos = -1;
        for (int i = 0; i < n; i++) {
            if (array[i] % 2 == 1) {
                if (pos == -1) {
                    pos = i;
                }
                else {
                    count += 2*(i-pos);
                    pos = -1;
                }
            }
        }
        if (pos == -1) {
            return count.ToString();
        }
        else {
            return "NO";
        }
    }
}
