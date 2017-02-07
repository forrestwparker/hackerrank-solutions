using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write(WriteStaircase(n));
    }
    
    static string WriteStaircase(int n) {
        string staircase = "";
        for (int row = 0; row < n; row++) {
            for (int col = 0; col < n; col++) {
                if (row+col < n-1) {
                    staircase += " ";
                }
                else {
                    staircase += "#";
                }
            }
            if (row != n-1) {
                staircase += "\n";
            }
        }
        return staircase.ToString();
    }
}
