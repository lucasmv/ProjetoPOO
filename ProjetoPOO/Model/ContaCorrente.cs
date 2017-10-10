using Lucas.ProjetoPOO.Exceptions;
using System;

namespace Lucas.ProjetoPOO.Model
{
    public class ContaCorrente : Conta
    {

        private static int totalDeContas = 0;

        public ContaCorrente()
        {
            totalDeContas++;
        }

        public int ProximaConta()
        {
            return totalDeContas + 1;
        }

        public override void Saca(double valor)
        {
            if (valor > Saldo)
                throw new SaldoInsuficienteException();
            else if (valor < 0)
                throw new ArgumentException();
            else
                Saldo -= valor;
        }
    }
}
