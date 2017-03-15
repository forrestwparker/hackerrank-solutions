using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] temp = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(temp[0]);
        int k = Convert.ToInt32(temp[1]);
        temp = Console.ReadLine().Split(' ');
        int[] queen = Array.ConvertAll(temp, Int32.Parse);
        Stack<int[]> obstacles = new Stack<int[]>();
        for (int i = 0; i < k; i++) {
            temp = Console.ReadLine().Split(' ');
            obstacles.Push(Array.ConvertAll(temp, Int32.Parse));
        }
        Attack(n, k, queen, obstacles);
    }
    
    static void Attack(int n, int k, int[] queen, Stack<int[]> obstacles) {
        int[] tracker = SetTracker(n, queen);
        while (obstacles.Count > 0) {
            CheckObstacle(n, queen, obstacles.Pop(), tracker);
        }
        Console.WriteLine(tracker.Sum());
    }
    
    static int[] SetTracker (int n, int[] queen) {
        int[] tracker = new int[8];
        tracker[0] = queen[0]-1;
        tracker[1] = n-queen[1];
        tracker[2] = n-queen[0];
        tracker[3] = queen[1]-1;
        tracker[4] = Math.Min(queen[0]-1, queen[1]-1);
        tracker[5] = Math.Min(queen[0]-1, n-queen[1]);
        tracker[6] = Math.Min(n-queen[0], n-queen[1]);
        tracker[7] = Math.Min(n-queen[0], queen[1]-1);
        return tracker;
    }
    
    static void CheckObstacle (int n, int[] queen, int[] obstacle, int[] tracker) {
        int rowdelta = obstacle[0]-queen[0];
        int coldelta = obstacle[1]-queen[1];
        if (rowdelta == 0 || coldelta == 0 || Math.Abs(rowdelta) == Math.Abs(coldelta)) {
            UpdateTracker(n, tracker, rowdelta, coldelta);
        }
    }
    
    static void UpdateTracker(int n, int[] tracker, int rowdelta, int coldelta) {
        if (rowdelta == 0) {
            if (coldelta > 0) {
                tracker[1] = Math.Min(tracker[1], coldelta-1);
            }
            else if (coldelta < 0) {
                tracker[3] = Math.Min(tracker[3], -coldelta-1);
            }
        }
        else if (coldelta == 0) {
            if (rowdelta > 0) {
                tracker[2] = Math.Min(tracker[2], rowdelta-1);
            }
            else if (rowdelta < 0) {
                tracker[0] = Math.Min(tracker[0], -rowdelta-1);
            }
        }
        else {
            if (rowdelta > 0) {
                if (coldelta > 0) {
                    tracker[6] = Math.Min(tracker[6], rowdelta-1);
                }
                else {
                    tracker[7] = Math.Min(tracker[7], rowdelta-1);
                }
            }
            else {
                if (coldelta > 0) {
                    tracker[5] = Math.Min(tracker[5], coldelta-1);
                }
                else {
                    tracker[4] = Math.Min(tracker[4], -rowdelta-1);
                }
            }
        }
    }
}