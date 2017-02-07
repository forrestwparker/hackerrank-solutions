using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        int n = Int32.Parse((Console.ReadLine().Split(' '))[0]);
        string[] temp = Console.ReadLine().Split(' ');
        int[] array = Array.ConvertAll(temp,Int32.Parse);
        Array.Sort(array);
        Console.WriteLine(MaxDist(n,array));
    }
    
    static int MaxDist(int n, int[] array) {
        int max = Math.Max(array[0], n-array[array.Length-1]-1);
        for (int i = 0; i < array.Length-1; i++) {
            max = Math.Max(max, (int)Math.Floor((double)((array[i+1]-array[i])/2)));
        }
        return max;
    }
}
