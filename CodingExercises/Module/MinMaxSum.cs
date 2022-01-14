using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingExercises
{
    public class MinMaxSum
    {
        public static string Result(List<int> arr)
        {
            long min = long.MaxValue, max = 0, sum = 0;
            for (int i = 0; i < arr.Count(); i++)
            {
                sum += arr[i];
                min = Math.Min(min, arr[i]);
                max = Math.Max(max, arr[i]);
            }

            return string.Format("{0} {1}",sum-max,sum-min);

        }
    }
}