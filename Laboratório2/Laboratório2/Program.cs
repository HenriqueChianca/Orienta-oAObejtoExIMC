using System;

namespace Laboratório2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente Cliente1 = new ContaCorrente("12345-6", "Bob Nelson");
            ContaPoupanca Cliente2 = new ContaPoupanca("71717-1", "Testolfo Rocha");
            ContaCorrente Cliente3 = new ContaCorrente("65432-1", "Lisa Leite");

            Cliente1.DepositarValor(5000);
            Cliente3.DepositarValor(2000);
            Cliente2.DepositarValor(1500);
            Console.WriteLine(Cliente1.TransferirDinheiro(600, Cliente2));

            Console.WriteLine(Cliente3.SacarValor(250));

            Console.WriteLine(Cliente3.TransferirDinheiro(400, Cliente2));

            Console.WriteLine(Cliente2.TransferirDinheiro(1000, Cliente1));

            Console.WriteLine(Cliente1.SacarValor(900));

            Console.WriteLine(Cliente1.TransferirDinheiro(1500, Cliente3));

            Console.WriteLine(Cliente2.TransferirDinheiro(1200, Cliente3));

            Console.WriteLine(Cliente1.SacarValor(2000));

            Cliente3.DepositarValor(100);

            Console.WriteLine(Cliente2.TransferirDinheiro(700, Cliente1));

            Console.WriteLine(Cliente1.VerificarSaldo());

            Console.WriteLine(Cliente2.VerificarSaldo());

            Console.WriteLine(Cliente3.VerificarSaldo());

            Console.WriteLine(Cliente1.TransferirDinheiro(50, Cliente2));

            Console.WriteLine(Cliente1.VerificarSaldo());

            Console.WriteLine(Cliente2.VerificarSaldo());

            Console.ReadLine();
        }
    }
}
