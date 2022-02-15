using System;

class Veiculo
{
    public int velAtual;
    private int velMax;
    protected bool ligado;
    public Veiculo(int velMax)
    {
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }
    public bool getligado()
    {
        return ligado;
    }
    public int getVelMax()
    {
        return velMax;
    }
}
class carro : Veiculo
{
    public string nome;
    public carro(string nome, int vm):base(vm)
    {
        this.nome = nome;
        ligado = true;
    }
}



namespace MEMBROS_PROTECTED
{
    class Program
    {
        static void Main(string[] args)
        {
            carro car = new carro("Novo carro", 120);
            Console.WriteLine("Nome......:{0}", car.nome);
            Console.WriteLine("Vel.Maxima:{0}", car.getVelMax());
            Console.WriteLine("Ligado....:{0}", car.getligado());
        }
    }
}
