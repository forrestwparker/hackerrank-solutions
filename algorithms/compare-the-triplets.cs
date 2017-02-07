using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_a0[0]);
        int a1 = Convert.ToInt32(tokens_a0[1]);
        int a2 = Convert.ToInt32(tokens_a0[2]);
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_b0[0]);
        int b1 = Convert.ToInt32(tokens_b0[1]);
        int b2 = Convert.ToInt32(tokens_b0[2]);
        int[] aliceTokens = new int[3] {a0, a1, a2};
        int[] bobTokens = new int[3] {b0, b1, b2};
        int[] scores = MakeScores(aliceTokens, bobTokens);
        Console.Write(String.Format("{0} {1}", scores[0], scores[1]));
    }
    
    static int[] MakeScores(int[] leftTokens, int[] rightTokens) {
        int[] scores = new int[2] {0, 0};
        for (int pair = 0; pair < 3; pair++) {
            if (leftTokens[pair] < rightTokens[pair]) {
                scores[1]++;
            }
            else if (leftTokens[pair] > rightTokens[pair]) {
                scores[0]++;
            }
        }
        return scores;
    }
}
