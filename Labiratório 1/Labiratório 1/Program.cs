using System;

namespace Labiratório_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bob Nelson
            Usuario usuarioBob = new Usuario("Bob Nelson", 37, 78, 1.70);
            usuarioBob.CalcularIMC();
            usuarioBob.Situacao();
            usuarioBob.Meta();
            Console.ReadLine();
            Console.WriteLine("");

            //Testolfo Rocha
            Usuario usuarioTestolfo = new Usuario("Testolfo Rocha", 43, 60, 1.65);
            usuarioTestolfo.CalcularIMC();
            usuarioTestolfo.Situacao();
            usuarioTestolfo.Meta();
            Console.ReadLine();
            Console.WriteLine("");

            //Lisa Leite
            Usuario usuarioLisa = new Usuario("Lisa Leite", 22, 92, 1.72);
            usuarioLisa.CalcularIMC();
            usuarioLisa.Situacao();
            usuarioLisa.Meta();
            Console.ReadLine();
            Console.WriteLine("");

        }
    }
}
