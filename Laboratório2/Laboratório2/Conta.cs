using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratório2
{
    class Conta
    {
        private String idConta;
        private String nomeCorrentista;
        protected double saldoAtual;

        public Conta(string idConta, string nomeCorrentista)
        {
            this.idConta = idConta;
            this.nomeCorrentista = nomeCorrentista;
            this.saldoAtual = 0;
        }

        protected string IdConta
        {
            get
            {
                return idConta;
            }

        }

        protected string NomeCorrentista
        {
            get
            {
                return nomeCorrentista;
            }

        }

        protected double SaldoAtual
        {
            get
            {
                return saldoAtual;
            }



        }

        public string VerificarSaldo()
        {

            if (saldoAtual > 0)
            {
                return $"Seu saldo atual é: {saldoAtual.ToString("C")}";
            }
            else
            {
                return "Saldo atual indisponivel.";
            }
        }

        public virtual string TransferirDinheiro(double valorTransferencia, Conta contaDestinatario)
        {
            return "Espécie de conta não foi informada.";
        }

        public virtual string DebitarValorTransferencia(double valor)
        {
            return "Espécie de conta não foi informada, por favor tente novamente.";
        }

        public virtual String SacarValor(double valor)
        {
            return "Operação não realizada. Saldo insuficiente!";
        }
        public void DepositarValor(double valor)
        {
            saldoAtual = saldoAtual + valor;
        }
    }
}
