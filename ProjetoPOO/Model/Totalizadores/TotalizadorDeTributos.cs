using Lucas.ProjetoPOO.Interface;

namespace Lucas.ProjetoPOO.Totalizadores
{
    public class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        public void Aculula(Tributavel conta)
        {
            Total += conta.CalculaTributo();
        }
    }
}
