using System;

namespace loop_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            Console.WriteLine("Digite os valores a serem armazenados");
            for (int i=0; i< num.Length; i++)
            {

               // Console.WriteLine("Digite os valores a serem armazenados");

                num[i]=int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Valor de num na pos {0}: {1}", i, num[i]);          
            }
            
        }
    }
}
