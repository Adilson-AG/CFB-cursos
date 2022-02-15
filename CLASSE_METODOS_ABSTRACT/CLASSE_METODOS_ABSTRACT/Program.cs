using System;

abstract class Veiculo //CLASSE BASE ABSTRATA
{
    protected int VelMax;
    protected int VelAtual;
    protected bool ligado;

    public Veiculo()
    {
        ligado = false;
        VelAtual = 0;
    }
    public void setLigado(bool ligado)
    {
        this.ligado = ligado;
    }
    public int getVelAtual()
    {
        return VelAtual;
    }

    abstract public void aceleracao(int mult );
}
class Carro : Veiculo
{
    public Carro()
    {
        VelMax = 120;
        
    }
   override public void  aceleracao(int mult)
    {
        VelAtual += 10 * mult; ;
    }
}

namespace CLASSE_METODOS_ABSTRACT
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.aceleracao(2);
            Console.WriteLine(carro.getVelAtual());
        }
    }
}
