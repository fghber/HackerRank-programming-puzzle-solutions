using System;
using System.Collections.Generic;
using System.IO;
class Solution {    
    
    //http://www.luschny.de/math/factorial/FastFactorialFunctions.htm
    static int fact(int start, int n) {
        int i;
        if (n <= 16) { 
            int r = start;
            for (i = start + 1; i < start + n; i++)
                r *= i;
            return r;
        }
        i = n / 2;
        return fact(start, i) * fact(start + i, n - i);
    }   
    
    static double PAtMostX(int n, int x, double p, double q) {
        //sum = S0-k nCk(n x) * p^x * q^(n-x) /*pseudo code*/
        double sum = 0.0;
        for(int i = 0; i<=x; i++) {
            sum += PExactX(n, i, p, q);
        }
        return sum;
    }    
    
    static double PAtLeastX(int n, int x, double p, double q) {
        return 1.0-PAtMostX(n,x,p,q); // AtLeast: -> 1 - ^P(X)
    }
    
    static double PExactX(int n, int k, double p, double q) {
        //nCk(n x) * p^x * q^(n-x) /*pseudo code*/
        return fact(1, n)/(fact(1,k)*fact(1,n-k)) * Math.Pow(p, k) * Math.Pow(q, n-k);
    }
    
    static void Main(String[] args) {
        string[] input = Console.ReadLine().Split(' ');
        double p = Convert.ToDouble(input[0])/100;
        int n = Convert.ToInt32(input[1]);
        
        //at most 2 bad pistons: fav outcomes / #total outcomes -> exact 8, 9, or 10 good
        var x = PAtMostX(n, 2, p, 1.0-p);        
        Console.WriteLine(Math.Round(x, 3));
        
        //at least 2 bad pistons -> 1 - at most 1 bad
        var y = PAtLeastX(n, 1, p, 1.0-p);    
        Console.WriteLine(Math.Round(y, 3));        
    }
}