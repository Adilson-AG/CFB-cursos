using System;

public interface Veiculo { 
   
void ligar();
void desligar();
void info();

}
public interface Combate
{
    void disparar();
}
class Carro:Veiculo,Combate // Herda as interfaces ***** É PRECISO IMPLEMENTAR OS MÉTODOS DAS INTERFACES AQUI  
{
    public bool ligado;
    private int municao;

   public  Carro()
    {
        SetMunicao(100);
    }
    public void SetMunicao(int qtde)
    {
        this.municao = qtde;
    }

    public void ligar()
    {
        this.ligado = true;
    }
    public void desligar()
    {
        this.ligado = false;
    }
    public void disparar()
    {

    }
    public void info()
    {

    }
}





namespace INTTERFACES_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
        }
    }
}
