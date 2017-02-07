using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string time = Console.ReadLine();
        string militaryTime = ConvertToMilitaryTime(time);
        Console.Write(militaryTime);
    }
    
    static string ConvertToMilitaryTime(string time) {
        int[] mil = new int[3] {0, 0, 0};
        string milTime = "";
        for (int i = 0; i < 3; i++) {
            mil[i] = 10*Int32.Parse(time.ElementAt(3*i).ToString())+Int32.Parse(time.ElementAt(3*i+1).ToString());
        }
        if (mil[0] == 12) {
            mil[0] = 0;
        }
        if (time.ElementAt(8) == 'P') {
            mil[0] += 12;
        }
        for (int i = 0; i < 3; i++) {
            if (mil[i] < 10) {
                milTime += "0";
            }
            milTime += mil[i].ToString();
            if (i != 2) {
                milTime += ":";
            }
        }
        return milTime;
    }
}
