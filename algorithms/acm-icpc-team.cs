using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        char[][] ppl = new char[n][];
        for (int i = 0; i < n; i++) {
            ppl[i] = Console.ReadLine().ToCharArray();
        }
        Console.WriteLine(FindTeams(n,m,ppl));
    }
    
    static string FindTeams(int n, int m, char[][] ppl) {
        int max = 0;
        int teamcount = 0;
        for (int i = 0; i < n-1; i++) {
            for (int j = i+1; j < n; j++) {
                int sum = 0;
                for (int k = 0; k < m; k++) {
                    if (ppl[i][k] == '1' || ppl[j][k] == '1') {
                        sum++;
                    }
                }
                if (sum == max) {
                    teamcount++;
                }
                else if (sum > max) {
                    max = sum;
                    teamcount = 1;
                }
            }
        }
        return max.ToString()+"\n"+teamcount.ToString();
    }
}