using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
class Solution
{

    static int CountHits(int[] fruits, int tree, int s, int t)
    {
        int count = 0;
        for (int i = 0; i < fruits.Length; i++)
        {
            int at = tree + fruits[i];
            if (at >= s && at <= t)
                count++;
        }
        //can be done with a LINQ one-liner too, but that's considerable slower
        //count += fruits.Where(x => (x + tree >= s && x + tree <= t)).Count();
        return count;
    }

    static void Main(String[] args)
    {
        string[] tokens_s = Console.ReadLine().Split(' ');
        int s = Convert.ToInt32(tokens_s[0]);
        int t = Convert.ToInt32(tokens_s[1]);
        string[] tokens_a = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(tokens_a[0]);
        int b = Convert.ToInt32(tokens_a[1]);
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        string[] apple_temp = Console.ReadLine().Split(' ');
        int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
        string[] orange_temp = Console.ReadLine().Split(' ');
        int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);

        Console.WriteLine(CountHits(apple, a, s, t));
        Console.WriteLine(CountHits(orange, b, s, t));
    }
}