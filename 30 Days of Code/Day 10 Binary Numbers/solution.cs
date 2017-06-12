using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        //Binary shift through the number and find the max no. of consecutive ones.
        int consecutiveOnes = 0, max =0;
        while (n > 0) {
            if (n%2==1) consecutiveOnes++; 
            else consecutiveOnes=0;
            max = Math.Max(consecutiveOnes, max);
            n >>= 1;
        }                
        Console.WriteLine(max);
    }
}