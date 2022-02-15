using System;
class Carro
{
    private int[] velMax = new int[5] { 80, 120, 160, 240, 300 };

    public int this[int i]
    {
        get//obter valor .....leitura
        {
            return velMax[i];
        }
        set//escrita de valor
        {
            if (value < 0)
            {
                velMax[i] = 0;
            }
            else if (value > 220)
            {
                velMax[i] = 220;
            }
            else
            {
                velMax[i] = value;
            }
        }
    }

    public Carro()
    {
        
    }

}


namespace INDEXADORES
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();

            c1[4] = 200;
            Console.WriteLine("Velocidade {0}", c1[4]);
        }
    }
}

