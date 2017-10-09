namespace ProjetoPOO
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
