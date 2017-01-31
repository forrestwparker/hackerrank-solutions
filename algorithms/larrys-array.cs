using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int T = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < T; i++) {
            int n = Int32.Parse(Console.ReadLine());
            string[] temparray = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(temparray, Int32.Parse);
            Console.WriteLine(CanSort(n, array));
        }
    }
    
    static string CanSort(int n, int[] array) {
        bool[] spotchecked = new bool[n];
        int count = 0;
        for (int i = 0; i < n; i++) {
            if (spotchecked[i] == false) {
                int pos = i;
                count--;
                while (spotchecked[pos] == false) {
                    count++;
                    spotchecked[pos] = true;
                    pos = array[pos]-1;
                }
            }
        }
        if (count % 2 == 0) {
            return "YES";
        }
        else {
            return "NO";
        }
    }
}