using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco
{
    class Conta 
    {
        private int idConta;
        private int senha;
        private double saldo;
        private List<Operacao> historicoOP = new List<Operacao>();
        private Agencia agencia;
        private List<Cliente> titulares = new List<Cliente>();

        public int IdConta { get => idConta; set => idConta = value; }
        public int Senha { get => senha; set => senha = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        internal List<Operacao> HistoricoOP { get => historicoOP; set => historicoOP = value; }
        internal Agencia Agencia { get => agencia; set => agencia = value; }
        internal List<Cliente> Titulares { get => titulares; set => titulares = value; }

        public Conta(int numero, int senha, Agencia agencia, Cliente primeiroTitular)
        {
            
        }

        public void adicionarTitular (Cliente novoTitular)
        {

        }

        public void depositar (double valor)
        {

        }

        public void informarSaldo()
        {

        }

        public void exibirExtrato()
        {

        }
    } 
}
