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
        private static int contadorAgencia = 0;


        public int IdAgencia { get => idAgencia; set => idAgencia = value; }

        public void setCliente(Cliente cliente)
        {
            if (cliente != null)
            {
                this.clientes.Add(cliente);
                Console.WriteLine("Cliente {0} cadastrado com sucesso na agência {1}", cliente.Nome, this.IdAgencia);

            }
        }


        public void setConta (Conta conta)
        {
            if (conta != null)
            {
                this.contas.Add(conta);
                Console.WriteLine("Conta {0} adicionada com sucesso", conta.IdConta);
            }

            else
                Console.WriteLine("Conta nula enviada para ser cadastrada");
        }

      
        public static int ContadorAgencia { get => contadorAgencia; set => contadorAgencia = value; }

        public Agencia(int numero)
        {
            ContadorAgencia++;
            this.IdAgencia = ContadorAgencia;
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
            try
            {
                return this.clientes.SingleOrDefault(p => p.Cpf == cpf);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Não existe esse cliente nessa agência");
                return null;
            }

        }

        public Conta getConta (int idConta)
        {
            try
            {
                return this.contas.SingleOrDefault(p => p.IdConta == idConta);
            }

            catch (ArgumentNullException)
            {
                Console.WriteLine("Não existe a conta {0} na agência {1}", idConta, this.IdAgencia);
                return null;
            }
        }

        public Boolean verificaCPF(int cpf)
        {
            return true;
        }
    }
}
