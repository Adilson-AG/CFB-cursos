using System;

class Base
{

    public Base()
    {
        Console.WriteLine("Construtor da classe base");
    }
    virtual public void info()
    { }
    
}
class Derivada : Base
{
    public Derivada()
    {
        Console.WriteLine("Construtor da classe derivada");
    }
    override public void info()
    {
        Console.WriteLine("Derivada");
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
            Base Ref;
            Derivada derivada = new Derivada();
            Derivada1 derivad = new Derivada1();
           
            Ref = derivad;
            Ref.info();
        }
    }
}
