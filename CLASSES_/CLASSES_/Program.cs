using System;

namespace CLASSES_
{
    public class Jogador
    {
       public int energia=100;
       public bool vivo=true;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador();
            Jogador j3 = new Jogador();

            j1.energia = 50;
            j3.energia = 30;
            Console.WriteLine("Energia jogador 1:{0}", j1.energia);
            Console.WriteLine("Energia jogador 2:{0}", j2.energia);
            Console.WriteLine("Energia jogador 3:{0}", j3.energia);
        }
    }
}
