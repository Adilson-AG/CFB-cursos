using System;

namespace METODO_CONSTRUTOR
{
    public class Jogador
    {
        public int energia;
        public bool vivo;
        public string nome;
        public Jogador(string n)
        {
            energia = 100;
            vivo = true;
            nome = n;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string nome1;
            Console.WriteLine("Digite o nome do jogador 1");
            nome1 = Console.ReadLine();

            Jogador j1 = new Jogador(nome1);
            Jogador j2 = new Jogador("Antonio");
            //Jogador j3 = new Jogador();

            j1.energia = 50;
            j2.energia = 30;
            Console.WriteLine("Nome jogador 1:{0}", j1.nome);
            Console.WriteLine("Nome jogador 2:{0}", j2.nome);
            //Console.WriteLine("Energia jogador 3:{0}", j3.energia);
        }
    }
}

