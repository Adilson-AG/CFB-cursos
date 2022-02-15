using System;
//STRUCT É UM TIPO QUE ARMAZENA TIPOS DIFERENTES ....INT...STRING...

struct Carro
{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo,string cor)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }
    public void info()
    {
        Console.WriteLine("Marca.: {0}", this.marca);
        Console.WriteLine("Modelo: {0}", this.modelo);
        Console.WriteLine("Cor...: {0}", this.cor);
    }
}




namespace STRUCT
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Honda","Civic","Cinza");
            //c1.marca = "VW";
            //c1.modelo = "Golf";
            //c1.cor = "Azul";

            c1.info();
        }
    }
}
