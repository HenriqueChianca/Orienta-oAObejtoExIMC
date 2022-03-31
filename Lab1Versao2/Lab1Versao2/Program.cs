using System;

namespace Lab1Versao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aperte enter para iniciar o programa!");

            //Bob Nelson
            Aluno usuarioBob = new Aluno("Bob Nelson", 37, 78, 1.70f);
            Console.ReadLine();
            Console.WriteLine($"{usuarioBob.nome} tem o IMC de {usuarioBob.CalcularIMC()},{usuarioBob.DescreverSituacaoCorporal()} e precisa perder {usuarioBob.CalcularMetaPerdaPeso()}kg");

            //Testolfo Rocha
            Aluno usuarioTestolfo = new Aluno("Testolfo Rocha", 43, 60, 1.65f);
           
            Console.ReadLine();
            Console.WriteLine($"{usuarioTestolfo.nome} tem o IMC de {usuarioTestolfo.CalcularIMC()},{usuarioTestolfo.DescreverSituacaoCorporal()} e precisa perder {usuarioTestolfo.CalcularMetaPerdaPeso()}kg");

            //Lisa Leite
            Aluno usuarioLisa = new Aluno("Lisa Leite", 22, 92, 1.72f);
           
            Console.ReadLine();
            Console.WriteLine($"{usuarioLisa.nome} tem o IMC de {usuarioLisa.CalcularIMC()},{usuarioLisa.DescreverSituacaoCorporal()} e precisa perder {usuarioLisa.CalcularMetaPerdaPeso()}kg");

        }
    }
}
