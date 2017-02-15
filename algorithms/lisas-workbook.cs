using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string[] temp = Console.ReadLine().Split(' ');
        int[] pagearray = Array.ConvertAll(temp, Int32.Parse);
        int n = pagearray[0];
        int k = pagearray[1];
        temp = Console.ReadLine().Split(' ');
        pagearray = Array.ConvertAll(temp, Int32.Parse);
        Console.WriteLine(Special(n, k, pagearray));
    }
    
    static int Special(int n, int k, int[] pagearray) {
        int page = 0;
        int count = 0;
        for (int i = 0; i < n; i++) {
            for (int j = 1; j <= pagearray[i]; j++) {
                if (j % k == 1 % k) {
                    page++;
                }
                if (j == page) {
                    count++;
                }
            }
        }
        return count;
    }
}