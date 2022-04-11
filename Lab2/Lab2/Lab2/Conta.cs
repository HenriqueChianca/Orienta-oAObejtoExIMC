using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
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

        public virtual String SacarValor(double valor)
        {
            return "Operação não realizada";
        }
        public void DepositarValor(double valor)
        {
            saldoAtual = saldoAtual + valor;
        }
    }
}
