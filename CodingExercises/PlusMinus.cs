using System;
using System.Collections.Generic;

namespace CodingExercises
{
    /*
    Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. 
    Print the decimal value of each fraction on a new line with 6 places after the decimal.
    */
    public class PlusMinus
    {
        public static List<string> Result(List<int> arr)
        {
            int nLength = arr.Count;

            decimal nNegative = 0;
            decimal nZero = 0;
            decimal nPositive = 0;

            for(int i=0; i < nLength; i++)
            {
                if (arr[i] == 0)
                    nZero++;
                if (arr[i] < 0)
                    nNegative++;
                if (arr[i] > 0)
                    nPositive++;
            }

            List<string> resultset = new List<string>();
            resultset.Add(string.Format("{0:N6}", (decimal)(nPositive / nLength)));
            resultset.Add(string.Format("{0:N6}", (decimal)(nNegative / nLength)));
            resultset.Add(string.Format("{0:N6}", (decimal)(nZero / nLength)));

            return resultset;
        }
    }
}
