using Lucas.ProjetoPOO.Exceptions;
using Lucas.ProjetoPOO.Interface;
using System;

namespace Lucas.ProjetoPOO.Model
{
    public class ContaInvestimento : Conta, Tributavel
    {
        public double CalculaTributo()
        {
            return Saldo * 0.03;
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
