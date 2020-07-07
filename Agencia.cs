using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco
{
    class Agencia
    {
        private int idAgencia;
        private List<Cliente> clientes = new List<Cliente>();
        private List<Conta> contas = new List<Conta>();


        public int IdAgencia { get => idAgencia; set => idAgencia = value; }
        internal List<Cliente> Clientes { get => clientes; set => clientes = value; }
        internal List<Conta> Contas { get => contas; set => contas = value; }

        public Agencia(int numero)
        {

        }

        public void cadastrarCliente (string nome, string cpf)
        {

        }

        public int abrirConta (int senha, string cpfDoTitular)
        {
            return 0;
        }

        public void adicionarTitular (int idConta, string cpfDoTitular)
        {

        }

        public void depositar (int idConta, double valor)
        {

        }

        public void informarSaldo (int idConta)
        {

        }

        public void exibirExtrato (int idConta)
        {

        }

        public Cliente getCliente (string cpf)
        {
            return clientes[0];

        }

        public Conta getConta (int idConta)
        {
            return contas[0];
        }

        public Boolean verificaCPF(int cpf)
        {
            return true;
        }
    }
}
