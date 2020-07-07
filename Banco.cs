using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco
{
    class Banco
    {
        private string nomeBanco;
        private int idBanco;
        private List<Agencia> agencias = new List<Agencia>();

        public string NomeBanco { get => nomeBanco; set => nomeBanco = value; }
        public int IdBanco { get => idBanco; set => idBanco = value; }


        public Agencia get(int idAgencia)
        {
            try
            {
               return this.agencias.SingleOrDefault(p => p.IdAgencia == idAgencia); //seleciona a Agencia com id especifico
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Não há agência com esse ID");
                return null;
            }
     
        }
        public void set(Agencia ag)
        {
            if (ag != null)
            {
                this.agencias.Add(ag);
                Console.WriteLine("Agência número {0} cadastrada com sucesso no banco {1}", ag.IdAgencia, this.IdBanco);
            }

            else
                Console.WriteLine("Agência nula enviada para cadastro");

        }
                         
        //Métodos bancários

        public Banco(string nome, int numero)
        {
            this.NomeBanco = nome;
            this.IdBanco = numero;
        }

        public int abrirAgencia ()
        {
            Agencia ag = new Agencia(Agencia.ContadorAgencia);
            this.set(ag);   //chamando o método set para inserir uma nova agência na List<>
           
            return Agencia.ContadorAgencia;
        }

        public void depositar (int idAgencia, int idConta, double valor)
        {
            Agencia ag = this.get(idAgencia);

            if(ag != null)  
            {
                Conta conta = ag.getConta(idConta);

                if (conta != null)
                    conta.depositar(valor);     //somente será depositado se a conta e a agência existirem

                else
                    Console.WriteLine("Tentativa de depósito em uma conta nula");
                
            }

        }

        public void informarSaldo (int idAgencia, int idConta)
        {
            Agencia ag = this.getAgencia(idAgencia);

            if(ag != null)
            {
                Conta conta = ag.getConta(idConta);

                if (conta != null)
                    conta.informarSaldo();

                else
                    Console.WriteLine("Conta {0} não existente na agência {1}", idConta, idAgencia);
                
            }
        }

        public void exibirExtrato (int idAgencia, int idConta)
        {

        }

        public Agencia getAgencia (int idAgencia)
        {
            return agencias[0];
        }


    }
}
