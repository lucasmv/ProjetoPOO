using System;

namespace ProjetoPOO
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

        public abstract void Saca(double valor);

        public void Deposita(double valor)
        {
            if (valor > 0)
                Saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            if (Saldo >= valor && valor > 0)
            {
                Saca(valor);
                destino.Deposita(valor);
            }
        }


        public void DadosDaConta()
        {
            Console.WriteLine(string.Format("Número: {0}", Numero));
            Console.WriteLine(string.Format("Saldo: {0}", Saldo.ToString("0.00")));
        }
    }
}
