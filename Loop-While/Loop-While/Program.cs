using System;

namespace Loop_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int i = 0;
            while (i<num.Length)
            {
                Console.WriteLine("Adilson= {0}",i);
                i++;
            }
        }
    }
}
