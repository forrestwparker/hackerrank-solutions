using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int Q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < Q; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            char[] b = Console.ReadLine().ToCharArray();
            Console.WriteLine(Happy(n,b));
        }
    }
    
    static string Happy(int n, char[] b) {
        string output = "YES";
        if (b.Where(x => x == '_').Count() == 0) {
            output = Check(n,b);
        }
        else {
            char c = '_';
            for(int i = 0; i < n && output == "YES"; i++) {
                if (b[i] != '_' && b[i] != c) {
                    c = b[i];
                    if (b.Where(x => x == c).Count() == 1) {
                        output = "NO";
                    }
                }
            }
        }
        return output;
    }
    
    static string Check(int n, char[] b) {
        string output = "YES";
        if (b.Length == 1) {
            output = "NO";
        }
        for (int i = 1; i < n && output == "YES"; i++) {
            if (b[i] != b[i-1] && (i == n-1 || b[i] != b[i+1])) {
                output = "NO";
            }
        }
        return output;
    }
}
