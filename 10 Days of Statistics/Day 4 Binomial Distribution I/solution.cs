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
    
    static double PAtMost(int n, int x, double p, double q) {
        //sum = Sigma0-2 nCk(6 x) * p^x * q^(n-x) /*pseudo code*/
        double sum = 0.0;
        for(int i = 0; i<x; i++) {
            sum += PExactX(n, i, p, q);
        }
        return sum;
    }    
    
    static double PAtLeastX(int n, int x, double p, double q) {
        return 1.0-PAtMost(n,x,p,q); // AtLeast: -> 1 - ^P(X)
    }
    
    static double PExactX(int n, int k, double p, double q) {
        //nCk(6 x) * p^x * q^(n-x) /*pseudo code*/
        return fact(1, n)/(fact(1,k)*fact(1,n-k)) * Math.Pow(p, k) * Math.Pow(q, n-k);
        //return fact(1, n)/(fact(1,k)*fact(1,n-k)) / Math.Pow(2,6); //approximation for p=0.5
    }
    
    static void Main(String[] args) {
        //The ratio of boys to girls for babies born in Russia is 1.09 : 1. If there is 1 child born per birth,
        // what proportion of Russian families with exactly 6 children will have at _least_ 3 boys?
        double p = 1.09/2.09, q = 1.0/2.09;
        int n = 6, k = 3;
        // #fav outcomes / #total outcomes -> 3boys, 4boys , 5boys, 6boys
        var x = PAtLeastX(n, k, p, q);        
        Console.WriteLine(Math.Round(x, 3));
    }
}