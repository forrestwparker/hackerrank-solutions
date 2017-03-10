using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        int T = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < T; i++) {
            string s = Console.ReadLine();
            Console.WriteLine(NextWord(s));
        }
    }
    
    static string NextWord(string s) {
        char[] a = s.ToCharArray();
        int len = a.Length;
        int index = len-2;
        string output = "";
        while (index >= 0 && a[index] >= a[index+1]) {
            index--;
        }
        if (index == -1) {
            output = "no answer";
        }
        else {
            int sindex = index+1;
            while (sindex < len-1 && a[sindex+1] > a[index]) {
                sindex++;
            }
            char temp = a[index];
            a[index] = a[sindex];
            a[sindex] = temp;
            for (int i = 0; i < len; i++) {
                if (i <= index) {
                    output += a[i].ToString();
                }
                else {
                    output += a[len-i+index];
                }
            }
        }
        return output;
    }
}