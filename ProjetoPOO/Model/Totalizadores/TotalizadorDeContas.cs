﻿using Lucas.ProjetoPOO.Model;
using System.Collections.Generic;
using System.Linq;

namespace Lucas.ProjetoPOO.Totalizadores
{
    public class TotalizadorDeContas
    {
        private List<Conta> Contas = new List<Conta>();
        public double SaldoDeTodasContas
        {
            get
            {
                return Contas.Sum(x => x.Saldo);
            }
        }
        public void Adiciona(Conta c)
        {
            Contas.Add(c);
        }
    }
}
