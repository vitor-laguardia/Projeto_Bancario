using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco
{
    class Cliente
    {
        private string nome;
        private string cpf;
        private Agencia agencia;
        private List<Conta> contas = new List<Conta>();

        public Cliente (string nome, string cpf, Agencia agencia)
        {

        }

        public void adicionarTitularidade (Conta novaTitularidade)
        {

        }

        public void informarSaldo (int idConta)
        {

        }

        public void exibirExtrato(int idConta)
        {

        }
    }
}
