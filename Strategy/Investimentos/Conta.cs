namespace Strategy.Investimentos
{
    public class Conta
    {
        public double Saldo { get; private set; } 

        public Conta()
        {
            
        }

        public void Deposita(double valor)
        {
            Saldo += valor;
        }
    }
}