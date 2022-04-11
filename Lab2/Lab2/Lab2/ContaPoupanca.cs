using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class ContaPoupanca : Conta
    {
        const double tarifaSaque = 0.20 / 100;
       public ContaPoupanca(string idConta, string nomeCorrentista):base(idConta, nomeCorrentista)
        {
        }
        public override string SacarValor(double valor)
        {
            double valorTarifa = valor * tarifaSaque;
            if (SaldoAtual - valor - valorTarifa < 0)
            {
                return "Operação não realizada. SALDO INSUFICIENTE!";
            }
            saldoAtual = SaldoAtual - valor - valorTarifa;
            return "Operação realizada com sucesso!";
        }
    }
}
