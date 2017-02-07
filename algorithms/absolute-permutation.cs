using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            AbsPermutation(n, k);
            Console.WriteLine();
        }
    }
    
    static void AbsPermutation(int n, int k) {
        if (k == 0) {
            for (int i = 1; i <= n; i++) {
                Console.Write("{0} ", i);
            }
        }
        else if (n % k == 0 && ((int)(n/k)) % 2 == 0) {
            int count = 0;
            int sign = -1;
            for (int i = 1; i <= n; i++) {
                count++;
                if ((count-1) % k == 0) {
                    sign *= -1;
                }
                Console.Write("{0} ", (i+sign*k));
            }
        }
        else {
            Console.Write("-1");
        }
    }
}
