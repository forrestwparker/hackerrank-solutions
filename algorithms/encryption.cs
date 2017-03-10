using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        char[] array = Console.ReadLine().Replace(" ","").ToCharArray();
        Console.Write(Encrypt(array));
    }
    
    static string Encrypt(char[] array) {
        int l = array.Length;
        int c = (int)Math.Ceiling(Math.Sqrt(l));
        string output = "";
        for (int i = 0; i < c; i++) {
            int pos = i;
            while (pos < l) {
                output += array[pos].ToString();
                pos += c;
            }
            output += " ";
        }
        return output;
    }
}