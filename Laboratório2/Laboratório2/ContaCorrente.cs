using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratório2
{
    class ContaCorrente : Conta
    {
        const double tarifaSaqueContaCorrent = 0.0037d;
        const double tarifaTransferenciaContaCorrente = 0.001d;
        private string mensagemSaldoInsuficiente = "Operação não realizada. Saldo insuficiente!";

        public ContaCorrente(string numeroIndentificacao, string nomeCorrentista
               ) : base(numeroIndentificacao, nomeCorrentista)
        {

        }

        public override string SacarValor(double valor)
        {
            double valorTarifa = valor * tarifaSaqueContaCorrent;
            if (saldoAtual - valor - valorTarifa < 0)
            {
                return mensagemSaldoInsuficiente;
            }
            saldoAtual = saldoAtual - valor - valorTarifa;
            return "operação realizada com sucesso.";
        }

        public override string DebitarValorTransferencia(double valor)
        {
            double valorTarifa = valor * tarifaTransferenciaContaCorrente;
            if (saldoAtual - valor - valorTarifa < 0)
            {
                return mensagemSaldoInsuficiente;
            }
            saldoAtual = saldoAtual - valor - valorTarifa;
            return "operação realizada com sucesso.";
        }

        public override string TransferirDinheiro(double valorTransferencia,
            Conta contaDestinataria)
        {
            if (this.DebitarValorTransferencia(valorTransferencia) != mensagemSaldoInsuficiente)
            {
                contaDestinataria.DepositarValor(valorTransferencia);
                return "operação realizada com sucesso";
            }

            return mensagemSaldoInsuficiente;

        }
    }
}
