using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    public static void Main(String[] args)
    {
        int count = int.Parse(Console.ReadLine());
        int[] num = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);        
        num = num.OrderBy(i => i).ToArray();
        //3 7 8 5 12 14 21 13 18
        double[] quartiles = new double[3];
        int midIndex = count / 2;
        int q1Index = midIndex / 2;
        if (count % 2 == 0) {
            int quartileRange = midIndex;
            if (quartileRange % 2 == 0) {
                quartiles[0] = ((num[q1Index - 1] + num[q1Index]) / 2.0);                
                quartiles[2] = ((num[q1Index+midIndex -1] + num[q1Index+midIndex]) / 2.0);
            } else {
                quartiles[0] = num[q1Index];
                quartiles[2] = num[q1Index+midIndex];
            }            
            quartiles[1] = ((num[midIndex - 1] + num[midIndex]) / 2.0);            
        }
        else {
            int quartileRange = (num.Length-1)/2;
            if (quartileRange % 2 == 0) {
                quartiles[0] = ((num[q1Index - 1] + num[q1Index]) / 2.0);                
                quartiles[2] = ((num[q1Index+midIndex] + num[q1Index+midIndex+1]) / 2.0);
            } else {
                quartiles[0] = num[q1Index];
                quartiles[2] = num[q1Index+midIndex+1];
            }
            quartiles[1] = num[midIndex];            
        }                  
        foreach(double q in quartiles)
            Console.WriteLine(q);
    }
}