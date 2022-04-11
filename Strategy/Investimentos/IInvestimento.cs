namespace Strategy.Investimentos
{
    public interface IInvestimento
    {
        public double Calcula(Conta saldo);
    }
}