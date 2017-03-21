using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        char[] a = Console.ReadLine().ToCharArray();
        long n = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine(Counta(a,n));
    }
    
    static long Counta(char[] a, long n) {
        int alen = a.Length;
        int atota = a.Where(v => v == 'a').Count();
        int rem = (int)(n % (long)alen);
        int subtota = 0;
        for (int i = 0; i < rem; i++) {
            if (a[i] == 'a') {
                subtota++;
            }
        }
        return (long)(atota)*(long)((n-(long)rem)/(long)alen)+(long)subtota;
    }
}