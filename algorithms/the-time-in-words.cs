using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int h = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(MakeTimeIntoWords(h, m));
    }
    
    static string MakeTimeIntoWords(int h, int m) {
        Dictionary<int, string> timeWords = new Dictionary<int, string>();
        timeWords.Add(1, "one");
        timeWords.Add(2, "two");
        timeWords.Add(3, "three");
        timeWords.Add(4, "four");
        timeWords.Add(5, "five");
        timeWords.Add(6, "six");
        timeWords.Add(7, "seven");
        timeWords.Add(8, "eight");
        timeWords.Add(9, "nine");
        timeWords.Add(10, "ten");
        timeWords.Add(11, "eleven");
        timeWords.Add(12, "twelve");
        timeWords.Add(13, "thirteen");
        timeWords.Add(15, "quarter");
        timeWords.Add(20, "twenty");
        timeWords.Add(30, "half");
        
        string output = "";
        if (m == 0) {
            output = String.Format("{0} o' clock", timeWords[h]);
        }
        else {
            bool nextHour = false;
            if (m > 30) {
                h++;
                m = 60-m;
                nextHour = true;
            }
            if (timeWords.Keys.Contains(m)) {
                output = String.Format("{0} ", timeWords[m]);
            }
            else {
                int ones = m % 10;
                int tens = m - ones;
                if (tens < 20) {
                    output = String.Format("{0}teen ", timeWords[ones]);
                }
                else {
                    output = String.Format("{0} {1} ", timeWords[tens], timeWords[ones]);
                }
            }
            if (m != 15 && m != 30) {
                output += "minute";
                if (m != 1) {
                    output += "s";
                }
                output += " ";
            }
            if (nextHour) {
                output += "to ";
            }
            else {
                output += "past ";
            }
            output += timeWords[h];
        }
        return output;
    }
}
