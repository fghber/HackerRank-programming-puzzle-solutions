using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/*  find the value obtained by XOR-ing the contiguous subarrays, followed by XOR-ing the values thus obtained. */
class Solution {
    static void Main(String[] args) {
        int tests = Convert.ToInt32(Console.ReadLine());
        for (int _ = 0; _ < tests; _++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray(); // used like a functional map()
            
            /*A number XOR-ed with itself is 0. A number XOR with 0 stays the same: x ^ x = 0, x ^ 0 = x.
            Instead of iterating thru every posible continous subarray, 
            we calculate the no. of times each number appears in any subarray.*/           
                   
            if (n % 2 == 0)
                Console.WriteLine(0); //If the no. of times is even, x XOR x (n times) will give 0.
            else  // if there is an odd number of x-values, the result will be "x", thus we can ignore it.
            {
                int result = 0;
                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                        result = result ^ arr[i];                    
                }
                Console.WriteLine(result);
            }
        }
    }
}