using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratório2
{
    class ContaPoupanca : Conta
    {
        const double tarifaSaqueContaPoupanca = 0.002d;
        const double tarifaTransferenciaContaPoupanca = 0.0015d;
        private string mensagemInsuficienciaSaldo = "Saldo insuficiente.";

        public ContaPoupanca(string idConta, string nomeCorrentista) : base(idConta, nomeCorrentista)
        {
        }
        public override string SacarValor(double valor)
        {
            double valorTarifa = valor * tarifaSaqueContaPoupanca;
            if (SaldoAtual - valor - valorTarifa < 0)
            {
                return "Operação não realizada. SALDO INSUFICIENTE!";
            }
            saldoAtual = SaldoAtual - valor - valorTarifa;
            return "Operação realizada com sucesso!";
        }

        public override string DebitarValorTransferencia(double valor)
        {
            double valorTarifa = valor * tarifaTransferenciaContaPoupanca;
            if (saldoAtual - valor - valorTarifa < 0)
            {
                return mensagemInsuficienciaSaldo;
            }
            saldoAtual = saldoAtual - valor - valorTarifa;
            return "operação realizada com sucesso.";
        }

        public override string TransferirDinheiro(double valorTransferencia,
           Conta contaDestinataria)
        {
            if (this.DebitarValorTransferencia(valorTransferencia) != mensagemInsuficienciaSaldo)
            {
                contaDestinataria.DepositarValor(valorTransferencia);
                return "operação realizada com sucesso";
            }

            return mensagemInsuficienciaSaldo;
        }
    }
}
