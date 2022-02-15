using System;

namespace SOBRECARGA_CONSTRUTORES
{
    public class Jogador
    {
        public int energia;
        public bool vivo;
        public string nome;

        public Jogador()
        {
            energia = 100;
            vivo = true;
            nome = "Jogador";
        }
        public Jogador(string n)
        {
            energia = 100;
            vivo = true;
            nome = n;

        }
       
        public Jogador(string n,int e)
        {
            energia = e;
            vivo = false;
            nome = n;

        }
        public Jogador(string n,int e,bool v)
        {
            energia = e;
            vivo = v;
            nome = n;

        }
        public void info()
        {
            Console.WriteLine("Nome jogador: {0}", nome);
            Console.WriteLine("Energia jogador: {0}",energia);
            Console.WriteLine("Estado jogador: {0}\n",vivo );
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            

            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador("Antonio");
            Jogador j3 = new Jogador("Adilson",80);
            Jogador j4 = new Jogador("AdilsonA", 90,true);

            j1.info();
            j2.info();
            j3.info();
            j4.info();



        }
    }
}


