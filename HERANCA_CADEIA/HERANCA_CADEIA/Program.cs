using System;


class Veiculo //classe base
{
    private int rodas;
    public int velMax;
    private bool ligado;

    public Veiculo(int rodas)
    {
        this.rodas = rodas;
    }

    public void Ligar()
    {
        ligado = true;
    }
    public void Desligar()
    {
        ligado = false;
    }

    public string Getligado()
    {
        return (ligado ? "sim" : "não");//operador ternário (teste ? impressão caso verdadeiro senão : impressão)
        
    }
    public int getRodas()
    {
        return rodas;
    }
    public void setRodas(int rodas)
    {
        if (rodas < 0)
        {
            this.rodas = 0;
        }else if (rodas > 16)
        {
            this.rodas = 16;
        }
        else
        {
            this.rodas = rodas;
        }
      
    }
}
class Carro : Veiculo
{ 
    public string nome;
    public string cor;

    public Carro(string nome, string cor):base(4)
    {

        Ligar();
       
        velMax = 200;
        this.cor = cor;
        this.nome = nome;

    }
}
class CarroCombate : Carro
{
    public int municao;
    public CarroCombate() : base("turbão", "Azul")
    {
        municao = 100;
        setRodas(6);
    }
}

namespace HERANCA
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Ferrari", "Vermelho");
            Console.WriteLine("Cor.......:{0}", c1.cor);
            Console.WriteLine("Nome.....: {0}", c1.nome);
            Console.WriteLine("Rodas.....:{0}", c1.getRodas());
            Console.WriteLine("Vel.Maxima:{0}", c1.velMax);
            Console.WriteLine("Ligado....:{0} \n", c1.Getligado());
            Console.WriteLine("---------------------------------");


            CarroCombate c2= new CarroCombate();
            Console.WriteLine("\nCor.......:{0}", c2.cor);
            Console.WriteLine("Nome.....: {0}", c2.nome);
            Console.WriteLine("Rodas.....:{0}", c2.getRodas());
            Console.WriteLine("Vel.Maxima:{0}", c2.velMax);
            Console.WriteLine("Ligado....:{0}", c2.Getligado());
            Console.WriteLine("Munição....:{0} \n", c2.municao);



        }
    }
}