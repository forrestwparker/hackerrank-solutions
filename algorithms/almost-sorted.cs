using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Int32.Parse(Console.ReadLine());
        string[] temp = Console.ReadLine().Split(' ');
        int[] array = Array.ConvertAll(temp, Int32.Parse);
        n = array.Length;
        Console.WriteLine(CanSortQuickly(n, array));
    }
    
    static string CanSortQuickly(int n, int[] array) {
        string output = "no";
        List<int> keypoints = new List<int> {};
        int sign = 1;
        for (int i = 0; i < n-1; i++) {
            if (sign*(array[i+1]-array[i]) < 0) {
                keypoints.Add(i);
                sign *= -1;
            }
        }
        if (keypoints.Count > 0 && keypoints.Count <= 4) {
            if (keypoints.Count % 2 == 1) {
                keypoints.Add(n-1);
            }
            if (keypoints.Count == 2) {
                int a = keypoints[0];
                int b = keypoints[1];
                if ((a == 0 || array[b] > array[a-1])
                   && (b == a+1)
                   && (b == n-1 || array[a] < array[b+1])) {
                    output = String.Format("yes\nswap {0} {1}", a+1, b+1);
                }
                if (output == "no"
                   && (a == 0 || array[b] > array[a-1])
                   && (b == n-1 || array[a] < array[b+1])) {
                    output = String.Format("yes\nreverse {0} {1}", a+1, b+1);
                }
            }
            else {
                int a = keypoints[0];
                int b = keypoints[3];
                int c = keypoints[1];
                int d = keypoints[2];
                if ((a == 0 || array[b] > array[a-1])
                   && (array[b] < array[a+1])
                   && (array[a] > array[b-1])
                   && (b == n-1 || array[a] < array[b+1])
                   && c == a+1
                   && d == b-1) {
                    output = String.Format("yes\nswap {0} {1}", a+1, b+1);
                }
            }
        }
        return output;
    }
}