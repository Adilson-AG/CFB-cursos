//Aula enum CFB CURSOS YOUTUBE 

using System;

namespace aulaEnum
{
    class Aulaenum
    {
        enum DiaSemana { Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sabado};
        static void Main(string[] args)
        {
            //opções de conversão (cast) enum tipo personalizado pelo programador.
            // DiaSemana ds = DiaSemana.Domingo; 
            // DiaSemana ds =(DiaSemana) 3;
            int ds = (int)DiaSemana.Sexta;
            Console.WriteLine(ds);
        }
    }
}
