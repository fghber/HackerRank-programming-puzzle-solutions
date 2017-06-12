30 Days of Code using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
class Solution {
	
	//only good for numbers up to n=12
    static int simpleFactorial(int n) {
        return (n == 0) ? 1 n*fact(n-1);
    }   

    //http://www.luschny.de/math/factorial/FastFactorialFunctions.htm
    static BigInteger recfact(long start, long n) {
        long i;
        if (n <= 16) { 
            BigInteger r = new BigInteger(start);
            for (i = start + 1; i < start + n; i++) r *= i;
            return r;
        }
        i = n / 2;
        return recfact(start, i) * recfact(start + i, n - i);
    }
    static BigInteger factorial(long n) { return recfact(1, n); } 
    
    static void Main(String[] args) {
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(factorial(input));
    }
}