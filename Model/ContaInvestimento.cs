using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Model
{
    public class ContaInvestimento : Conta
    {

        //relacionado ao Resgate
        public double Sacar(double valor)
        {

            if (valor > this.SaldoAtual)
            {
                throw new ArgumentOutOfRangeException("Saldo insuficiente");
            }

            if (valor < 0)
            {
                throw new ArgumentOutOfRangeException("Valor do saque não pode ser negativo");
            }

            var SaldoAtual = this.SaldoAtual -= valor;
            return SaldoAtual;
        }

        //relacionado ao investimento
        public double Depositar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentOutOfRangeException("Valor do depósito não pode ser negativo");
            }
            else
            {
                SaldoAtual = this.SaldoInicial += valor;
            }

            return SaldoAtual;
        }


        public double RenderJuros()
        {
            var juros = this.SaldoInicial * (0.2 / 100);
            var SaldoAposJuros = this.SaldoInicial + juros;
            return SaldoAposJuros;
        }



        public ContaInvestimento RetornarCliente()
        {
            ContaInvestimento objCtaInvest = new ContaInvestimento();

            objCtaInvest.ID = 1;

            ClientePF objCliPF = new ClientePF();
            objCliPF.ID = 23;
            objCliPF.Nome = "Ellen Santos";
            objCliPF.CPF = "999.999.999-99";

            objCtaInvest.Cliente = objCliPF;

            objCtaInvest.NumeroAgencia = "0001";
            objCtaInvest.NumeroConta = "268594-3";
            objCtaInvest.numeroBanco = "265";
            objCtaInvest.SaldoInicial = 150000000;
            objCtaInvest.SaldoAtual = objCtaInvest.Sacar(1000);

            return objCtaInvest;

        }

        public List<ContaInvestimento> RetornarListaClientes()
        {
            List<ContaInvestimento> lstContas = new List<ContaInvestimento>();
            lstContas.Add(RetornarCliente());

            ContaInvestimento objCtaInvest1 = new ContaInvestimento();

            objCtaInvest1.ID = 2;

            ClientePF objCliPF1 = new ClientePF();
            objCliPF1.ID = 24;
            objCliPF1.Nome = "Fulano";
            objCliPF1.CPF = "888.888.888-88";

            objCtaInvest1.Cliente = objCliPF1;

            objCtaInvest1.NumeroAgencia = "0001";
            objCtaInvest1.NumeroConta = "268595-3";
            objCtaInvest1.numeroBanco = "265";
            objCtaInvest1.SaldoInicial = 100000;
            objCtaInvest1.SaldoAtual = objCtaInvest1.RenderJuros();

            lstContas.Add(objCtaInvest1);



            ContaInvestimento objCtaInvest2 = new ContaInvestimento();

            objCtaInvest2.ID = 3;

            ClientePF objCliPF2 = new ClientePF();
            objCliPF2.ID = 25;
            objCliPF2.Nome = "Beltrano";
            objCliPF2.CPF = "777.777.777-77";

            objCtaInvest2.Cliente = objCliPF2;

            objCtaInvest2.NumeroAgencia = "0001";
            objCtaInvest2.NumeroConta = "396589-3";
            objCtaInvest2.numeroBanco = "265";
            objCtaInvest2.SaldoInicial = 500;
            objCtaInvest2.SaldoAtual = objCtaInvest2.Depositar(1000);

            lstContas.Add(objCtaInvest2);

            return lstContas;
        }


    }
}