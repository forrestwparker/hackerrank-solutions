using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int t = Convert.ToInt32(tokens_n[1]);
        string[] width_temp = Console.ReadLine().Split(' ');
        int[] width = Array.ConvertAll(width_temp,Int32.Parse);
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_i = Console.ReadLine().Split(' ');
            int i = Convert.ToInt32(tokens_i[0]);
            int j = Convert.ToInt32(tokens_i[1]);
            Console.WriteLine(Vehicle(width, i, j));
        }
    }
    
    static int Vehicle(int[] array, int a, int b) {
        int output = 3;
        for (int i = a; i <= b; i++) {
            output = Math.Min(output, array[i]);
        }
        return output;
    }
}
