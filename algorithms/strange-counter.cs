using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        long t = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine(Output(t));
    }
    
    static long Output(long t) {
        long pow = (long)Math.Floor(Math.Log(Math.Ceiling((double)t/3),(double)2));
        long count = 3*(long)Math.Pow(2,pow);
        long mint = 3*(long)Math.Pow(2,pow)-2;
        return count-t+mint;
    }
}
