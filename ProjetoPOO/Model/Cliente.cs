using System;

namespace Lucas.ProjetoPOO.Model
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; set; }
        private bool EEmancipado { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome)
        {
            Nome = nome;
        }

        public bool EhMaiorDeIdade()
        {
            return Idade >= 18;
        }

        public void DadosDoCliente()
        {
            Console.WriteLine(string.Format("Nome: {0}", Nome));
            Console.WriteLine(string.Format("Idade: {0}", Idade));
            Console.WriteLine(string.Format("CPF: {0}", Cpf));
            Console.WriteLine(string.Format("RG: {0}", Rg));
            Console.WriteLine(string.Format("Endereço: {0}", Endereco));
        }

        public bool PodeAbrirContaSozinho
        {
            get
            {
                var maiorDeIdade = EhMaiorDeIdade();
                var emancipado = (this.EEmancipado);
                var possuiCPF = !string.IsNullOrEmpty(this.Cpf);
                return (maiorDeIdade || emancipado) && possuiCPF;
            }
        }
    }
}