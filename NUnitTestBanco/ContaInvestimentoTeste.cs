using NUnit.Framework;
using Model;

namespace NUnitTestBanco
{
    public class ContaInvestimentoTeste
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void TestarSaque()
        {
            double valorSaque = 400;
            double esperado = 1600;
            ContaInvestimento account = new ContaInvestimento();
            account.Cliente = new ClientePF();
            account.Cliente.ID = 4;
            account.NumeroAgencia = "001";
            account.numeroBanco = "236";
            account.NumeroConta = "335564";
            account.SaldoInicial = 1000;
            account.SaldoAtual = 2000;

            account.Sacar(valorSaque);

            Assert.AreEqual(esperado, account.SaldoAtual, 0.001, "Conta não debitada corretamente!");
        }

        [Test]
        public void TestarDepoisito()
        {
            double valorDeposito = -400;
            double esperado = 2000;
            ContaInvestimento account = new ContaInvestimento();
            account.Cliente = new ClientePF();
            account.Cliente.ID = 4;
            account.NumeroAgencia = "001";
            account.numeroBanco = "236";
            account.NumeroConta = "335564";
            account.SaldoInicial = 1000;


            account.Depositar(valorDeposito);

            Assert.AreEqual(esperado, account.SaldoAtual, 0.001, "Conta não debitada corretamente!");

        }
    }
}