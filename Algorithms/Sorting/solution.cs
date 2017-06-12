using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
class Solution {
    
    public class BigNumberComparatorFast : IComparer
    {
        public int Compare(object x, object y)
        {
            string s1 = x as string;
            if (s1 == null)
                return 0;

            string s2 = y as string;
            if (s2 == null)
                return 0;

            int len1 = s1.Length;
            int len2 = s2.Length;
            
            if(len1<len2)
                return -1;
            if(len2<len1)
                return 1;
            
            int result = 0;
            // numeric comparision is too slow
            /*BigInteger n1 = BigInteger.Parse(s1);
            BigInteger n2 = BigInteger.Parse(s2);
            result = n1.CompareTo(n2);*/
            // compare character-wise instead
            for(int i = 0; i < len1; i++)
            {
                if((int)s1[i] > (int)s2[i]) return 1;
                if((int)s1[i] < (int)s2[i]) return -1;
            }
            
            return 0;
        }
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] unsorted = new string[n];
        for(int unsorted_i = 0; unsorted_i < n; unsorted_i++){
           unsorted[unsorted_i] = Console.ReadLine();   
        }
        Array.Sort(unsorted, new BigNumberComparatorFast());
        foreach(string s in unsorted)
            Console.WriteLine(s);
    }
}