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
        public int NumeroID { get => numeroID; set => numeroID = value; }
        internal List<Agencia> Agencias { get => agencias; set => agencias = value; }

        //Métodos bancários

        public Banco(string nome, int numero)
        {

        }

        public int abrirAgencia ()
        {
            return 0;
        }

        public void depositar (int idAgencia, int idConta, double valor)
        {

        }

        public void informarSaldo (int idAgencia, int idConta)
        {

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
