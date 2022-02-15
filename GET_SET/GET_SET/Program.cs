using System;


class Carro
{
    private int velMax;

    public int Vm
    {
        get//obter valor .....leitura
        {
            return velMax; 
        }
        set//escrita de valor
        {
            if (value < 0)
            {
                velMax = 0;
            }else if (value > 220)
            {
                velMax = 220;
            }
            else
            {
                velMax = value;
            }
        }
    }

    public  Carro()
    {
        Vm =int.Parse( Console.ReadLine());
    }
    
}




namespace GET_SET
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
            Console.WriteLine("Velocidade {0}", c1.Vm);
        }
    }
}
