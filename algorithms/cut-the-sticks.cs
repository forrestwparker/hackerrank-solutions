using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        Console.WriteLine(Cut(arr));
    }
    
    static string Cut(int[] sticks) {
        string output = "";
        while(sticks.Length > 0) {
            output += sticks.Length.ToString()+"\n";
            int min = Min(sticks);
            sticks = sticks.Where(s => s > min).ToArray();
        }
        return output;
    }
    
    static int Min(int[] array) {
        int min = array[0];
        foreach(int i in array) {
            min = Math.Min(min, i);
        }
        return min;
    }
}