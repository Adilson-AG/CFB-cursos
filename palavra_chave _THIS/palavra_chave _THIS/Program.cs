using System;

class Calculo
{
    public int v1;
    public int v2;

    public Calculo(int v1, int v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }
    public int Somar()
    {
        return v1 + v2;
    }
}


namespace palavra_chave__THIS
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo c = new Calculo(10, 2);
            Console.WriteLine(c.Somar()); 
        }   
    }   
}
