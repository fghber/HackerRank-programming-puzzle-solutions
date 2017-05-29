using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
/*
Q: If the difference between the grade and the next multiple of 5 is less than 3, 
round the grade up to the next multiple of 5. 
If the value of grade is less than 38, no rounding occurs.
*/
class Solution {

    static int[] solve(int[] grades){
        for(int i=0; i< grades.Length; i++) {
            if(grades[i] < 38)
                continue;			
            //determine the nearest multiple of 5
            int nextFive = (int)Math.Round(grades[i] / 5.0) * 5; //67 -> 65; 73 -> 75
            if (grades[i] < nextFive)
                grades[i] = nextFive;;
			
			//this dreadful one-liner does the same
            //grades[i] = (grades[i] < 38 || grades[i] % 5 < 3 ? grades[i] : grades[i] + (5 - (grades[i] % 5)));
        }
        return grades;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] grades = new int[n];
        for(int grades_i = 0; grades_i < n; grades_i++){
           grades[grades_i] = Convert.ToInt32(Console.ReadLine());   
        }
        int[] result = solve(grades);
        Console.WriteLine(String.Join("\n", result));
    }
}
