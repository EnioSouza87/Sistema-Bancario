using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Sul
{
     class Cliente
    {
        private string nome;
        private string dataNasc;
        private string cpf;
        private string endereco;
        private double saldo;
        private int idCliente;
       

        public string Nome { get => nome; set => nome = value; }
        public string DataNasc { get => dataNasc; set => dataNasc = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
       

        public void Deposito(double valor)
        {
            if (valor>0)
            {
                this.saldo += valor;
            }
        }

        public bool Saque(double valor)
        {
            if (this.saldo>=valor)
            {
                this.saldo -= valor;
                return true;
            }
            return false;
        }

        public void Transferir(Cliente destino,double valor)
        {
            if (this.Saque(valor))
            {
                destino.Deposito(valor);
            }
        }
    }
}
