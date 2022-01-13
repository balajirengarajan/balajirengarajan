using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingExercises
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            CallMethod(CommonEnum.MethodCall.PlusMinus);
            
        }

        static void CallMethod(CommonEnum.MethodCall methodCall)
        {
            switch(methodCall)
            {
                case CommonEnum.MethodCall.PlusMinus:
                    Call_PlusMinus();
                break;

            }
        }

        static void Call_PlusMinus()
        {
            Console.WriteLine("Enter the size of the array :");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Enter space-separated integers that describe arr[n] :");
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<string> lstResult = PlusMinus.Result(arr);
            foreach (string item in lstResult)
            {
                Console.WriteLine(item);
            }
        }
    }
}
