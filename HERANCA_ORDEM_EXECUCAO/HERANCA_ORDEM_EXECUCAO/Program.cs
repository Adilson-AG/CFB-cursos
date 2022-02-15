using System;

class Base
{

    public Base()
    {
        Console.WriteLine("Construtor da classe base");
    }
}
class Derivada : Base
{
    public Derivada()
    {
        Console.WriteLine("Construtor da classe derivada");
    }
}
class Derivada1 : Derivada
{
    public Derivada1()
    {
        Console.WriteLine("Construtor da classe derivada1");
    }
}

namespace HERANCA_ORDEM_EXECUCAO
{
    class Program
    {
        static void Main(string[] args)
        {
            Derivada1 derivada = new Derivada1();

        }
    }
}
