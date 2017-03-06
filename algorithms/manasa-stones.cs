using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int T = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < T; i++) {
            int n = Int32.Parse(Console.ReadLine());
            int[] array = new int[2];
            for (int j = 0; j <= 1; j++) {
                array[j] = Int32.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            Console.WriteLine(Values(n-1, array));
        }
    }
    
    static string Values(int n, int[] array) {
        string output = "";
        if (array[0] == array[1]) {
            output += (n*array[0]).ToString();
        }
        else {
            for (int p = 0; p <= n; p++) {
                output += (p*array[1]+(n-p)*array[0]).ToString()+" ";
            }
        }
        return output;
    }
}
