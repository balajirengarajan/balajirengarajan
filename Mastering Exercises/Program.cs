using System;

namespace Mastering_Exercises
{
    class Program
    {
        static string[] logArray = new string[5] {"a","b","c","d","e"};
        static void Main(string[] args)
        {
            LogAllArray();
        }

        static void LogAllArray()
        {
            for(int i = 0;i<logArray.Length;i++)
            {
                for(int j=0;j<logArray.Length;j++)
                {
                    Console.WriteLine(logArray[i] + "," + logArray[j]);
        
                }
            }
        }
    }
}
