using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model
{
    public class Conta: IConta
    {

        public int ID { get; set; }
        public string NumeroAgencia { get; set; }

        public string NumeroConta { get; set; }

        public string numeroBanco { get; set; }

        public Cliente Cliente { get; set; }

        public double SaldoInicial { get; set; }

        public double SaldoAtual { get; set; }
        public double Sacar(double valor)
        {
            return 0;
        }

        public double Depositar(double valor)
        {
            return 0;
        }
    }
}
