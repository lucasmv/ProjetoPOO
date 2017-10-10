using Lucas.ProjetoPOO.Exceptions;
using Lucas.ProjetoPOO.Model;
using System;

namespace Lucas.ProjetoPOO.UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region [CLIENTE]

            var cliente = new Cliente("Lucas Magno");
            cliente.Idade = 28;
            cliente.Cpf = "999.999.999-99";
            cliente.Rg = "99.999.999";

            #endregion

            #region [CONTAS]

            var cp = new ContaPoupanca
            {
                Titular = cliente,
                Numero = 991
            };

            var cc = new ContaCorrente
            {
                Titular = cliente,
                Numero = 992
            };

            var ci = new ContaInvestimento
            {
                Titular = cliente,
                Numero = 993
            };

            cc.Deposita(1000);
            ci.Deposita(1000);
            cp.Deposita(1000);

            #endregion

            #region DADOS DO CLIENTE E CONTAS

            //cliente.DadosDoCliente();

            //cp.DadosDaConta();
            //ci.DadosDaConta();
            //cc.DadosDaConta();

            #endregion

            #region TOTALIZADOR DE CONTAS

            //var totalizadorDeContas = new TotalizadorDeContas();

            //totalizadorDeContas.Adiciona(cp);
            //totalizadorDeContas.Adiciona(ci);
            //totalizadorDeContas.Adiciona(cc);

            //Console.WriteLine("Saldo todas as contas: " + totalizadorDeContas.SaldoDeTodasContas);

            #endregion

            #region TOTALIZADOR DE TRIBUTOS

            //var totalizadorDeTributos = new TotalizadorDeTributos();

            //totalizadorDeTributos.Aculula(cp);
            //totalizadorDeTributos.Aculula(ci);

            //Console.WriteLine("Tributos: " + totalizadorDeTributos.Total);

            #endregion

            #region [EXCEPTIONS]

            //try
            //{
            //    cp.Saca(100000);
            //    Console.WriteLine("Dinheiro liberado.");
            //}
            //catch (SaldoInsuficienteException ex)
            //{
            //    Console.WriteLine("Saldo Insuficiente.");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Valor inválido para o saque");
            //}

            //try
            //{
            //    cp.Saca(-10);
            //    Console.WriteLine("Dinheiro liberado.");
            //}
            //catch (SaldoInsuficienteException ex)
            //{
            //    Console.WriteLine("Saldo Insuficiente.");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Valor inválido para o saque");
            //}

            #endregion

            #region OBJECT

            var cliente1 = new Cliente("Lucas")
            {
                Rg = "12345-6"
            };

            var cliente2 = new Cliente("Lucas")
            {
                Rg = "12345-6"
            };

            Console.WriteLine("Equals? " + cliente1.Equals(cliente2));
            Console.WriteLine("Equals? " + cliente.Equals(cliente2));

            Console.WriteLine(cliente.ToString());

            #endregion

            Console.ReadKey();

        }
    }
}
